namespace Binance.Requests.TradeApi;

/// <summary>
/// The inputs of the AccountTradeListUserData operation.
/// </summary>
public sealed record AccountTradeListUserDataRequest
{
    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public required string Symbol { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// This can only be used in combination with symbol.
    /// </summary>
    public long? OrderId { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? StartTime { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? EndTime { get; init; }

    /// <summary>
    /// Trade id to fetch from. Default gets most recent trades.
    /// </summary>
    public long? FromId { get; init; }

    /// <summary>
    /// Default 500; max 1000.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
