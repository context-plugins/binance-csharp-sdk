using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class AccountListUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private AccountListUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static AccountListUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static AccountListUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<AccountListUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AccountListUserDataErrorResponse : IErrorResponse<AccountListUserDataError>
{
    public static AccountListUserDataErrorResponse Instance { get; } = new();

    private AccountListUserDataErrorResponse()
    {
    }

    public Task<AccountListUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AccountListUserDataError.Create(response, ct);
}
