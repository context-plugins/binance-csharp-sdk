namespace Binance.Requests.Market;

/// <summary>
/// The inputs of the CompressedAggregateTradesList operation.
/// </summary>
public sealed record CompressedAggregateTradesListRequest
{
    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public required string Symbol { get; init; }

    /// <summary>
    /// Trade id to fetch from. Default gets most recent trades.
    /// </summary>
    public long? FromId { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? StartTime { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? EndTime { get; init; }

    /// <summary>
    /// Default 500; max 1000.
    /// </summary>
    public int? Limit { get; init; }
}
