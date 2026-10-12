using Binance.Models.Enums;

namespace Binance.Requests.Futures;

/// <summary>
/// The inputs of the GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserData operation.
/// </summary>
public sealed record GetFutureTickLevelOrderbookHistoricalDataDownloadLinkUserDataRequest
{
    public required string Symbol { get; init; }

    public required DataTypeEnum DataType { get; init; }

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
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
