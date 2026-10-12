namespace Binance.Requests.Market;

/// <summary>
/// The inputs of the OldTradeLookup operation.
/// </summary>
public sealed record OldTradeLookupRequest
{
    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public required string Symbol { get; init; }

    /// <summary>
    /// Default 500; max 1000.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// Trade id to fetch from. Default gets most recent trades.
    /// </summary>
    public long? FromId { get; init; }
}
