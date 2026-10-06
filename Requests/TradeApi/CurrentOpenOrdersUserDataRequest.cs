namespace Binance.Requests.TradeApi;

/// <summary>
/// The inputs of the CurrentOpenOrdersUserData operation.
/// </summary>
public sealed record CurrentOpenOrdersUserDataRequest
{
    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public string? Symbol { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
