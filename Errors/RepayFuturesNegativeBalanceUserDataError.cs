using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class RepayFuturesNegativeBalanceUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private RepayFuturesNegativeBalanceUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static RepayFuturesNegativeBalanceUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static RepayFuturesNegativeBalanceUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<RepayFuturesNegativeBalanceUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RepayFuturesNegativeBalanceUserDataErrorResponse : IErrorResponse<RepayFuturesNegativeBalanceUserDataError>
{
    public static RepayFuturesNegativeBalanceUserDataErrorResponse Instance { get; } = new();

    private RepayFuturesNegativeBalanceUserDataErrorResponse()
    {
    }

    public Task<RepayFuturesNegativeBalanceUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RepayFuturesNegativeBalanceUserDataError.Create(response, ct);
}
