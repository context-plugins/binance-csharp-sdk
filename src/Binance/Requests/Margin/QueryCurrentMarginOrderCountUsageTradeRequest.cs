namespace Binance.Requests.Margin;

/// <summary>
/// The inputs of the QueryCurrentMarginOrderCountUsageTrade operation.
/// </summary>
public sealed record QueryCurrentMarginOrderCountUsageTradeRequest
{
    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// <list type="bullet">
    ///   <item><description><c>TRUE</c> - For isolated margin</description></item>
    ///   <item><description><c>FALSE</c> - Default, not for isolated margin</description></item>
    /// </list>
    /// </summary>
    public string? IsIsolated { get; init; }

    /// <summary>
    /// isolated symbol, mandatory for isolated margin
    /// </summary>
    public string? Symbol { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
