namespace Binance.Requests.Staking;

/// <summary>
/// The inputs of the EthStakingAccountV2UserData operation.
/// </summary>
public sealed record EthStakingAccountV2UserDataRequest
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
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
