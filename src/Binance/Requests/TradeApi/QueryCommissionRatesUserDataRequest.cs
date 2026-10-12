namespace Binance.Requests.TradeApi;

/// <summary>
/// The inputs of the QueryCommissionRatesUserData operation.
/// </summary>
public sealed record QueryCommissionRatesUserDataRequest
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
}
