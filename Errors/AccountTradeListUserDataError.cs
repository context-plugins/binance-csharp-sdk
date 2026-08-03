using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class AccountTradeListUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private AccountTradeListUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static AccountTradeListUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static AccountTradeListUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<AccountTradeListUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AccountTradeListUserDataErrorResponse : IErrorResponse<AccountTradeListUserDataError>
{
    public static AccountTradeListUserDataErrorResponse Instance { get; } = new();

    private AccountTradeListUserDataErrorResponse()
    {
    }

    public Task<AccountTradeListUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AccountTradeListUserDataError.Create(response, ct);
}
