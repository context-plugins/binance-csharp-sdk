using Binance.Models.Enums;

namespace Binance.Requests.Margin;

/// <summary>
/// The inputs of the GetCrossOrIsolatedMarginCapitalFlowUserData operation.
/// </summary>
public sealed record GetCrossOrIsolatedMarginCapitalFlowUserDataRequest
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
    /// Required when querying isolated data
    /// </summary>
    public string? Symbol { get; init; }

    public Type3? Type { get; init; }

    /// <summary>
    /// Only supports querying the data of the last 90 days
    /// </summary>
    public long? StartTime { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? EndTime { get; init; }

    /// <summary>
    /// If fromId is set, the data with id &gt; fromId will be returned. Otherwise the latest data will be returned
    /// </summary>
    public long? FromId { get; init; }

    /// <summary>
    /// The number of data items returned each time is limited. Default 500; Max 1000.
    /// </summary>
    public long? Limit { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
