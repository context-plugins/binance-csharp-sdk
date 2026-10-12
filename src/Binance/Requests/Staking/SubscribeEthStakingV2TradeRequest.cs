namespace Binance.Requests.Staking;

/// <summary>
/// The inputs of the SubscribeEthStakingV2Trade operation.
/// </summary>
public sealed record SubscribeEthStakingV2TradeRequest
{
    /// <summary>
    /// Amount in ETH, limit 4 decimals
    /// </summary>
    public required double Amount { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
