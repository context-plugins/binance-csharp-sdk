namespace Binance.Requests.Margin;

/// <summary>
/// The inputs of the GetAllCrossMarginPairsMarketData operation.
/// </summary>
public sealed record GetAllCrossMarginPairsMarketDataRequest
{
    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public required string Symbol { get; init; }
}
