namespace Binance.Requests.Margin;

/// <summary>
/// The inputs of the QueryMarginPriceIndexMarketData operation.
/// </summary>
public sealed record QueryMarginPriceIndexMarketDataRequest
{
    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public required string Symbol { get; init; }
}
