using Binance.Models.Enums;

namespace Binance.Requests.Market;

/// <summary>
/// The inputs of the TradingDayTicker operation.
/// </summary>
public sealed record TradingDayTickerRequest
{
    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public string? Symbol { get; init; }

    public string? Symbols { get; init; }

    /// <summary>
    /// Default: 0 (UTC)
    /// </summary>
    public string? TimeZone { get; init; }

    /// <summary>
    /// Supported values: FULL or MINI.
    /// If none provided, the default is FULL
    /// </summary>
    public TypeEnum? Type { get; init; }
}
