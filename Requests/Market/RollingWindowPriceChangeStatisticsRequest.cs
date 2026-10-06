namespace Binance.Requests.Market;

/// <summary>
/// The inputs of the RollingWindowPriceChangeStatistics operation.
/// </summary>
public sealed record RollingWindowPriceChangeStatisticsRequest
{
    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public string? Symbol { get; init; }

    public string? Symbols { get; init; }

    /// <summary>
    /// Defaults to 1d if no parameter provided.
    /// Supported windowSize values:
    /// 1m,2m....59m for minutes
    /// 1h, 2h....23h - for hours
    /// 1d...7d - for days.
    /// <para>
    /// Units cannot be combined (e.g. 1d2h is not allowed)
    /// </para>
    /// </summary>
    public string? WindowSize { get; init; }

    /// <summary>
    /// Supported values: FULL or MINI.
    /// If none provided, the default is FULL
    /// </summary>
    public string? Type { get; init; }
}
