using Binance.Models.Enums;

namespace Binance.Requests.TradeApi;

/// <summary>
/// The inputs of the NewOrderListOcoTrade operation.
/// </summary>
public sealed record NewOrderListOcoTradeRequest
{
    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public required string Symbol { get; init; }

    public required Side Side { get; init; }

    public required double Quantity { get; init; }

    /// <summary>
    /// Supported values : <c>STOP_LOSS_LIMIT</c>, <c>STOP_LOSS</c>, <c>LIMIT_MAKER</c>
    /// </summary>
    public required string AboveType { get; init; }

    /// <summary>
    /// Supported values : <c>STOP_LOSS_LIMIT</c>, <c>STOP_LOSS</c>, <c>LIMIT_MAKER</c>
    /// </summary>
    public required string BelowType { get; init; }

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
    /// <c>listClientOrderId</c> is distinct from the <c>aboveClientOrderId</c> and the <c>belowCLientOrderId</c>.
    /// </summary>
    public string? ListClientOrderId { get; init; }

    /// <summary>
    /// Arbitrary unique ID among open orders for the above order. Automatically generated if not sent
    /// </summary>
    public string? AboveClientOrderId { get; init; }

    /// <summary>
    /// Note that this can only be used if <c>aboveTimeInForce</c> is <c>GTC</c>.
    /// </summary>
    public double? AboveIcebergQty { get; init; }

    public double? AbovePrice { get; init; }

    /// <summary>
    /// Can be used if <c>aboveType</c> is <c>STOP_LOSS</c> or <c>STOP_LOSS_LIMIT</c>.
    /// Either <c>aboveStopPrice</c> or <c>aboveTrailingDelta</c> or both, must be specified.
    /// </summary>
    public double? AboveStopPrice { get; init; }

    public double? AboveTrailingDelta { get; init; }

    /// <summary>
    /// Required if the <c>aboveType</c> is <c>STOP_LOSS_LIMIT</c>.
    /// </summary>
    public AboveTimeInForce? AboveTimeInForce { get; init; }

    /// <summary>
    /// Arbitrary numeric value identifying the above order within an order strategy.
    /// </summary>
    public double? AboveStrategyId { get; init; }

    /// <summary>
    /// Arbitrary numeric value identifying the above order strategy.
    /// Values smaller than 1000000 are reserved and cannot be used.
    /// </summary>
    public long? AboveStrategyType { get; init; }

    /// <summary>
    /// Arbitrary unique ID among open orders for the below order. Automatically generated if not sent
    /// </summary>
    public string? BelowClientOrderId { get; init; }

    /// <summary>
    /// Note that this can only be used if <c>belowTimeInForce</c> is <c>GTC</c>.
    /// </summary>
    public double? BelowIcebergQty { get; init; }

    /// <summary>
    /// Can be used if <c>belowType</c> is <c>STOP_LOSS_LIMIT</c> or <c>LIMIT_MAKER</c> to specify the limit price.
    /// </summary>
    public double? BelowPrice { get; init; }

    /// <summary>
    /// Can be used if <c>belowType</c> is <c>STOP_LOSS</c> or <c>STOP_LOSS_LIMIT</c>.
    /// Either <c>belowStopPrice</c> or <c>belowTrailingDelta</c> or both, must be specified.
    /// </summary>
    public double? BelowStopPrice { get; init; }

    public double? BelowTrailingDelta { get; init; }

    /// <summary>
    /// Required if the <c>belowType</c> is <c>STOP_LOSS_LIMIT</c>.
    /// </summary>
    public BelowTimeInForce? BelowTimeInForce { get; init; }

    /// <summary>
    /// Arbitrary numeric value identifying the below order within an order strategy.
    /// </summary>
    public double? BelowStrategyId { get; init; }

    /// <summary>
    /// Arbitrary numeric value identifying the below order strategy.
    /// Values smaller than 1000000 are reserved and cannot be used.
    /// </summary>
    public long? BelowStrategyType { get; init; }

    /// <summary>
    /// Set the response JSON. MARKET and LIMIT order types default to FULL, all other orders default to ACK.
    /// </summary>
    public NewOrderRespType? NewOrderRespType { get; init; }

    /// <summary>
    /// The allowed enums is dependent on what is configured on the symbol. The possible supported values are EXPIRE_TAKER, EXPIRE_MAKER, EXPIRE_BOTH, NONE.
    /// </summary>
    public SelfTradePreventionMode? SelfTradePreventionMode { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
