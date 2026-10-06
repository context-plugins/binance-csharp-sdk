namespace Binance.Requests.SimpleEarn;

/// <summary>
/// The inputs of the RedeemLockedProductTrade operation.
/// </summary>
public sealed record RedeemLockedProductTradeRequest
{
    /// <summary>
    /// 1234
    /// </summary>
    public required string PositionId { get; init; }

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
