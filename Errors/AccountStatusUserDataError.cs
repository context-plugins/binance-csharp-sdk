using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class AccountStatusUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private AccountStatusUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static AccountStatusUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static AccountStatusUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<AccountStatusUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AccountStatusUserDataErrorResponse : IErrorResponse<AccountStatusUserDataError>
{
    public static AccountStatusUserDataErrorResponse Instance { get; } = new();

    private AccountStatusUserDataErrorResponse()
    {
    }

    public Task<AccountStatusUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AccountStatusUserDataError.Create(response, ct);
}
