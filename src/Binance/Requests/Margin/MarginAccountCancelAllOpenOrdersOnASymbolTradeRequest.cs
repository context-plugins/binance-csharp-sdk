using Binance.Models.Enums;

namespace Binance.Requests.Margin;

/// <summary>
/// The inputs of the MarginAccountCancelAllOpenOrdersOnASymbolTrade operation.
/// </summary>
public sealed record MarginAccountCancelAllOpenOrdersOnASymbolTradeRequest
{
    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public required string Symbol { get; init; }

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
    public IsIsolated? IsIsolated { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
