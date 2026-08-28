using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class TradingDayTickerError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private TradingDayTickerError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static TradingDayTickerError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static TradingDayTickerError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<TradingDayTickerError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class TradingDayTickerErrorResponse : IErrorResponse<TradingDayTickerError>
{
    public static TradingDayTickerErrorResponse Instance { get; } = new();

    private TradingDayTickerErrorResponse()
    {
    }

    public Task<TradingDayTickerError> Map(HttpResponseMessage response, CancellationToken ct) =>
        TradingDayTickerError.Create(response, ct);
}
