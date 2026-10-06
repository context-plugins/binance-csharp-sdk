using Binance.Models.Enums;

namespace Binance.Requests.Market;

/// <summary>
/// The inputs of the HrTickerPriceChangeStatistics24 operation.
/// </summary>
public sealed record HrTickerPriceChangeStatistics24Request
{
    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public string? Symbol { get; init; }

    public string? Symbols { get; init; }

    /// <summary>
    /// Supported values: FULL or MINI.
    /// If none provided, the default is FULL
    /// </summary>
    public TypeEnum? Type { get; init; }
}
