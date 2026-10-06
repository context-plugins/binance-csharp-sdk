using Binance.Models.Enums;

namespace Binance.Requests.FuturesAlgo;

/// <summary>
/// The inputs of the VolumeParticipationVpNewOrderTrade operation.
/// </summary>
public sealed record VolumeParticipationVpNewOrderTradeRequest
{
    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public required string Symbol { get; init; }

    public required Side Side { get; init; }

    /// <summary>
    /// Quantity of base asset; The notional (quantity * mark price(base asset)) must be more than the equivalent of 10,000 USDT and less than the equivalent of 1,000,000 USDT
    /// </summary>
    public required double Quantity { get; init; }

    /// <summary>
    /// Represent the relative speed of the current execution; ENUM: LOW, MEDIUM, HIGH
    /// </summary>
    public required Urgency Urgency { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// Default BOTH for One-way Mode ; LONG or SHORT for Hedge Mode. It must be sent in Hedge Mode.
    /// </summary>
    public PositionSide? PositionSide { get; init; }

    /// <summary>
    /// A unique id among Algo orders (length should be 32 characters)， If it is not sent, we will give default value
    /// </summary>
    public string? ClientAlgoId { get; init; }

    /// <summary>
    /// 'true' or 'false'. Default 'false'; Cannot be sent in Hedge Mode; Cannot be sent when you open a position
    /// </summary>
    public bool? ReduceOnly { get; init; }

    /// <summary>
    /// Limit price of the order; If it is not sent, will place order by market price by default
    /// </summary>
    public double? LimitPrice { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
