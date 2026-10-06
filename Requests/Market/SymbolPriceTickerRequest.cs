namespace Binance.Requests.Market;

/// <summary>
/// The inputs of the SymbolPriceTicker operation.
/// </summary>
public sealed record SymbolPriceTickerRequest
{
    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public string? Symbol { get; init; }

    public string? Symbols { get; init; }
}
