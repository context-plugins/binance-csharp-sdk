namespace Binance.Requests.Blvt;

/// <summary>
/// The inputs of the RedeemBlvtUserData operation.
/// </summary>
public sealed record RedeemBlvtUserDataRequest
{
    /// <summary>
    /// BTCDOWN, BTCUP
    /// </summary>
    public required string TokenName { get; init; }

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
