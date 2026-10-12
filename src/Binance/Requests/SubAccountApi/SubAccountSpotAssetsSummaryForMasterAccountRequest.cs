namespace Binance.Requests.SubAccountApi;

/// <summary>
/// The inputs of the SubAccountSpotAssetsSummaryForMasterAccount operation.
/// </summary>
public sealed record SubAccountSpotAssetsSummaryForMasterAccountRequest
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
    /// Sub-account email
    /// </summary>
    public string? Email { get; init; }

    /// <summary>
    /// Default 1
    /// </summary>
    public int? Page { get; init; }

    /// <summary>
    /// Default:10 Max:20
    /// </summary>
    public int? Size { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
