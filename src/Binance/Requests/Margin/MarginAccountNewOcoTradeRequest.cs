using Binance.Models.Enums;

namespace Binance.Requests.Margin;

/// <summary>
/// The inputs of the MarginAccountNewOcoTrade operation.
/// </summary>
public sealed record MarginAccountNewOcoTradeRequest
{
    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public required string Symbol { get; init; }

    public required Side Side { get; init; }

    public required double Quantity { get; init; }

    /// <summary>
    /// Order price
    /// </summary>
    public required double Price { get; init; }

    public required double StopPrice { get; init; }

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
    /// A unique Id for the entire orderList
    /// </summary>
    public string? ListClientOrderId { get; init; }

    /// <summary>
    /// A unique Id for the limit order
    /// </summary>
    public string? LimitClientOrderId { get; init; }

    public double? LimitIcebergQty { get; init; }

    /// <summary>
    /// A unique Id for the stop loss/stop loss limit leg
    /// </summary>
    public string? StopClientOrderId { get; init; }

    /// <summary>
    /// If provided, stopLimitTimeInForce is required.
    /// </summary>
    public double? StopLimitPrice { get; init; }

    public double? StopIcebergQty { get; init; }

    public StopLimitTimeInForce? StopLimitTimeInForce { get; init; }

    /// <summary>
    /// Set the response JSON.
    /// </summary>
    public NewOrderRespType? NewOrderRespType { get; init; }

    /// <summary>
    /// Default <c>NO_SIDE_EFFECT</c>
    /// </summary>
    public SideEffectType? SideEffectType { get; init; }

    /// <summary>
    /// The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE.
    /// </summary>
    public SelfTradePreventionMode? SelfTradePreventionMode { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
