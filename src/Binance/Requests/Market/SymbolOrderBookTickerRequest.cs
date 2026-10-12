namespace Binance.Requests.Market;

/// <summary>
/// The inputs of the SymbolOrderBookTicker operation.
/// </summary>
public sealed record SymbolOrderBookTickerRequest
{
    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public string? Symbol { get; init; }

    public string? Symbols { get; init; }
}
