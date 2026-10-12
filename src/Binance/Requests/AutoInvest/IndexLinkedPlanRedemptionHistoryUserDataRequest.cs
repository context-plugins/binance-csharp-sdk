namespace Binance.Requests.AutoInvest;

/// <summary>
/// The inputs of the IndexLinkedPlanRedemptionHistoryUserData operation.
/// </summary>
public sealed record IndexLinkedPlanRedemptionHistoryUserDataRequest
{
    public required long RequestId { get; init; }

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
    /// Current querying page. Start from 1. Default:1
    /// </summary>
    public int? Current { get; init; }

    public string? Asset { get; init; }

    /// <summary>
    /// Default:10 Max:100
    /// </summary>
    public int? Size { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
