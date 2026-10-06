namespace Binance.Requests.Margin;

/// <summary>
/// The inputs of the QueryCrossMarginFeeDataUserData operation.
/// </summary>
public sealed record QueryCrossMarginFeeDataUserDataRequest
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
    /// Defaults to user's vip level
    /// </summary>
    public int? VipLevel { get; init; }

    /// <summary>
    /// Coin name
    /// </summary>
    public string? Coin { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
