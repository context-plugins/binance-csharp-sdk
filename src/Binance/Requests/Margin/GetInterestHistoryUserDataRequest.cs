namespace Binance.Requests.Margin;

/// <summary>
/// The inputs of the GetInterestHistoryUserData operation.
/// </summary>
public sealed record GetInterestHistoryUserDataRequest
{
    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    public string? Asset { get; init; }

    /// <summary>
    /// Isolated symbol
    /// </summary>
    public string? IsolatedSymbol { get; init; }

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

    /// <summary>
    /// Default: false. Set to true for archived data from 6 months ago
    /// </summary>
    public string? Archived { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
