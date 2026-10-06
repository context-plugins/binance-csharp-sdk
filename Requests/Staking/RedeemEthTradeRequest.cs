namespace Binance.Requests.Staking;

/// <summary>
/// The inputs of the RedeemEthTrade operation.
/// </summary>
public sealed record RedeemEthTradeRequest
{
    /// <summary>
    /// Amount in BETH, limit 8 decimals
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
    /// WBETH or BETH, default to BETH
    /// </summary>
    public string? Asset { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
