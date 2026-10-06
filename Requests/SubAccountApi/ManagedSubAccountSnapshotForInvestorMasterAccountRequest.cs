namespace Binance.Requests.SubAccountApi;

/// <summary>
/// The inputs of the ManagedSubAccountSnapshotForInvestorMasterAccount operation.
/// </summary>
public sealed record ManagedSubAccountSnapshotForInvestorMasterAccountRequest
{
    /// <summary>
    /// Sub-account email
    /// </summary>
    public required string Email { get; init; }

    /// <summary>
    /// "SPOT", "MARGIN"(cross), "FUTURES"(UM)
    /// </summary>
    public required string Type { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? StartTime { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? EndTime { get; init; }

    /// <summary>
    /// min 7, max 30, default 7
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
