namespace Binance.Requests.SimpleEarn;

/// <summary>
/// The inputs of the RedeemFlexibleProductTrade operation.
/// </summary>
public sealed record RedeemFlexibleProductTradeRequest
{
    public required string ProductId { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// true or false, default to false
    /// </summary>
    public bool? RedeemAll { get; init; }

    /// <summary>
    /// if redeemAll is false, amount is mandatory
    /// </summary>
    public double? Amount { get; init; }

    /// <summary>
    /// SPOT,FUND,ALL, default SPOT
    /// </summary>
    public string? DestAccount { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
