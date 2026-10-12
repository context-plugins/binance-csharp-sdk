using Binance.Core.Validation.Attributes;

namespace Binance.Requests.Market;

/// <summary>
/// The inputs of the OrderBook operation.
/// </summary>
public sealed record OrderBookRequest
{
    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public required string Symbol { get; init; }

    /// <summary>
    /// If limit &gt; 5000, then the response will truncate to 5000
    /// </summary>
    [Maximum(5000)]
    public int Limit { get; init; } = 100;
}
