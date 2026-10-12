namespace Binance.Requests.TradeApi;

/// <summary>
/// The inputs of the QueryOrderUserData operation.
/// </summary>
public sealed record QueryOrderUserDataRequest
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
    /// Order id
    /// </summary>
    public long? OrderId { get; init; }

    /// <summary>
    /// Order id from client
    /// </summary>
    public string? OrigClientOrderId { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
