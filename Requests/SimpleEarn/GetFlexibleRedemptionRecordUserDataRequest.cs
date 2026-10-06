namespace Binance.Requests.SimpleEarn;

/// <summary>
/// The inputs of the GetFlexibleRedemptionRecordUserData operation.
/// </summary>
public sealed record GetFlexibleRedemptionRecordUserDataRequest
{
    public string? ProductId { get; init; }

    public string? RedeemId { get; init; }

    public string? Asset { get; init; }

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

    /// <summary>
    /// Default:10 Max:100
    /// </summary>
    public int? Size { get; init; }
}
