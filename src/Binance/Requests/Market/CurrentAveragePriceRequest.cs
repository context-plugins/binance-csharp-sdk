namespace Binance.Requests.Market;

/// <summary>
/// The inputs of the CurrentAveragePrice operation.
/// </summary>
public sealed record CurrentAveragePriceRequest
{
    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public required string Symbol { get; init; }
}
