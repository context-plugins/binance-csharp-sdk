using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class AccountInfoUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private AccountInfoUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static AccountInfoUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static AccountInfoUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<AccountInfoUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AccountInfoUserDataErrorResponse : IErrorResponse<AccountInfoUserDataError>
{
    public static AccountInfoUserDataErrorResponse Instance { get; } = new();

    private AccountInfoUserDataErrorResponse()
    {
    }

    public Task<AccountInfoUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AccountInfoUserDataError.Create(response, ct);
}
