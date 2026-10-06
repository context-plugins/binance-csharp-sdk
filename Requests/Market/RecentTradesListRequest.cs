namespace Binance.Requests.Market;

/// <summary>
/// The inputs of the RecentTradesList operation.
/// </summary>
public sealed record RecentTradesListRequest
{
    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public required string Symbol { get; init; }

    /// <summary>
    /// Default 500; max 1000.
    /// </summary>
    public int? Limit { get; init; }
}
