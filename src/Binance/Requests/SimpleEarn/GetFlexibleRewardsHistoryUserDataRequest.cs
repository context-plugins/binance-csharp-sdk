namespace Binance.Requests.SimpleEarn;

/// <summary>
/// The inputs of the GetFlexibleRewardsHistoryUserData operation.
/// </summary>
public sealed record GetFlexibleRewardsHistoryUserDataRequest
{
    /// <summary>
    /// "BONUS", "REALTIME", "REWARDS"
    /// </summary>
    public required string Type { get; init; }

    public string? ProductId { get; init; }

    public string? Asset { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? StartTime { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? EndTime { get; init; }
}
