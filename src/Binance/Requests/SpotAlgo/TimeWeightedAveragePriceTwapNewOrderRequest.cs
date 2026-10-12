using Binance.Models.Enums;

namespace Binance.Requests.SpotAlgo;

/// <summary>
/// The inputs of the TimeWeightedAveragePriceTwapNewOrder operation.
/// </summary>
public sealed record TimeWeightedAveragePriceTwapNewOrderRequest
{
    /// <summary>
    /// Trading symbol, e.g. BNBUSDT
    /// </summary>
    public required string Symbol { get; init; }

    public required Side Side { get; init; }

    public required double Quantity { get; init; }

    public required int Duration { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    public string? ClientAlgoId { get; init; }

    public double? LimitPrice { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
