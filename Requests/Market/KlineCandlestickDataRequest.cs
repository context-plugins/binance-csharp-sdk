using Binance.Models.Enums;

namespace Binance.Requests.Market;

/// <summary>
/// The inputs of the KlineCandlestickData operation.
/// </summary>
public sealed record KlineCandlestickDataRequest
{
    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public required string Symbol { get; init; }

    /// <summary>
    /// kline intervals
    /// </summary>
    public required Interval Interval { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? StartTime { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? EndTime { get; init; }

    /// <summary>
    /// Default: 0 (UTC)
    /// </summary>
    public string? TimeZone { get; init; }

    /// <summary>
    /// Default 500; max 1000.
    /// </summary>
    public int? Limit { get; init; }
}
