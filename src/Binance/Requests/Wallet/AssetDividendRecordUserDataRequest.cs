using Binance.Core.Validation.Attributes;

namespace Binance.Requests.Wallet;

/// <summary>
/// The inputs of the AssetDividendRecordUserData operation.
/// </summary>
public sealed record AssetDividendRecordUserDataRequest
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
    /// UTC timestamp in ms
    /// </summary>
    public long? StartTime { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? EndTime { get; init; }

    [Maximum(500)]
    public int Limit { get; init; } = 20;

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
