using Binance.Models.Enums;

namespace Binance.Requests.TradeApi;

/// <summary>
/// The inputs of the NewOrderListOtocoTrade operation.
/// </summary>
public sealed record NewOrderListOtocoTradeRequest
{
    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public required string Symbol { get; init; }

    /// <summary>
    /// Supported values: LIMIT,LIMIT_MAKER
    /// </summary>
    public required WorkingType WorkingType { get; init; }

    /// <summary>
    /// BUY,SELL
    /// </summary>
    public required WorkingSide WorkingSide { get; init; }

    public required double WorkingPrice { get; init; }

    /// <summary>
    /// Sets the quantity for the working order.
    /// </summary>
    public required double WorkingQuantity { get; init; }

    /// <summary>
    /// This can only be used if workingTimeInForce is GTC.
    /// </summary>
    public required double WorkingIcebergQty { get; init; }

    /// <summary>
    /// BUY,SELL
    /// </summary>
    public required PendingSide PendingSide { get; init; }

    /// <summary>
    /// Sets the quantity for the pending order.
    /// </summary>
    public required double PendingQuantity { get; init; }

    /// <summary>
    /// Supported values: LIMIT_MAKER, STOP_LOSS, and STOP_LOSS_LIMIT
    /// </summary>
    public required PendingAboveType PendingAboveType { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// Arbitrary unique ID among open order lists. Automatically generated if not sent.
    /// A new order list with the same <c>listClientOrderId</c> is accepted only when the previous one is filled or completely expired.
    /// <c>listClientOrderId</c> is distinct from the <c>workingClientOrderId</c> and the <c>pendingClientOrderId</c>.
    /// </summary>
    public string? ListClientOrderId { get; init; }

    /// <summary>
    /// Set the response JSON.
    /// </summary>
    public NewOrderRespType? NewOrderRespType { get; init; }

    /// <summary>
    /// The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE.
    /// </summary>
    public SelfTradePreventionMode? SelfTradePreventionMode { get; init; }

    /// <summary>
    /// Arbitrary unique ID among open orders for the working order. Automatically generated if not sent.
    /// </summary>
    public string? WorkingClientOrderId { get; init; }

    /// <summary>
    /// GTC, IOC, FOK
    /// </summary>
    public WorkingTimeInForce? WorkingTimeInForce { get; init; }

    /// <summary>
    /// Arbitrary numeric value identifying the working order within an order strategy.
    /// </summary>
    public double? WorkingStrategyId { get; init; }

    /// <summary>
    /// Arbitrary numeric value identifying the working order strategy.
    /// Values smaller than 1000000 are reserved and cannot be used.
    /// </summary>
    public long? WorkingStrategyType { get; init; }

    /// <summary>
    /// Arbitrary unique ID among open orders for the pending above order. Automatically generated if not sent.
    /// </summary>
    public string? PendingAboveClientOrderId { get; init; }

    public double? PendingAbovePrice { get; init; }

    public double? PendingAboveStopPrice { get; init; }

    public double? PendingAboveTrailingDelta { get; init; }

    /// <summary>
    /// This can only be used if pendingAboveTimeInForce is GTC.
    /// </summary>
    public double? PendingAboveIcebergQty { get; init; }

    public PendingAboveTimeInForce? PendingAboveTimeInForce { get; init; }

    /// <summary>
    /// Arbitrary numeric value identifying the pending above order within an order strategy.
    /// </summary>
    public double? PendingAboveStrategyId { get; init; }

    /// <summary>
    /// Arbitrary numeric value identifying the pending above order strategy.
    /// Values smaller than 1000000 are reserved and cannot be used.
    /// </summary>
    public long? PendingAboveStrategyType { get; init; }

    /// <summary>
    /// Supported values: LIMIT_MAKER, STOP_LOSS, and STOP_LOSS_LIMIT
    /// </summary>
    public PendingBelowType? PendingBelowType { get; init; }

    /// <summary>
    /// Arbitrary unique ID among open orders for the pending below order. Automatically generated if not sent.
    /// </summary>
    public string? PendingBelowClientOrderId { get; init; }

    public double? PendingBelowPrice { get; init; }

    public double? PendingBelowStopPrice { get; init; }

    public double? PendingBelowTrailingDelta { get; init; }

    /// <summary>
    /// This can only be used if pendingBelowTimeInForce is GTC.
    /// </summary>
    public double? PendingBelowIcebergQty { get; init; }

    public PendingBelowTimeInForce? PendingBelowTimeInForce { get; init; }

    /// <summary>
    /// Arbitrary numeric value identifying the pending below order within an order strategy.
    /// </summary>
    public double? PendingBelowStrategyId { get; init; }

    /// <summary>
    /// Arbitrary numeric value identifying the pending below order strategy.
    /// Values smaller than 1000000 are reserved and cannot be used.
    /// </summary>
    public long? PendingBelowStrategyType { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
