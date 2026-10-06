namespace Binance.Requests.AutoInvest;

/// <summary>
/// The inputs of the QuerySourceAssetListUserData operation.
/// </summary>
public sealed record QuerySourceAssetListUserDataRequest
{
    public required string UsageType { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    public string? TargetAsset { get; init; }

    public long? IndexId { get; init; }

    public bool? FlexibleAllowedToUse { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
