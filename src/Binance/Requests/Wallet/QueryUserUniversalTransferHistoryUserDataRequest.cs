using Binance.Models.Enums;

namespace Binance.Requests.Wallet;

/// <summary>
/// The inputs of the QueryUserUniversalTransferHistoryUserData operation.
/// </summary>
public sealed record QueryUserUniversalTransferHistoryUserDataRequest
{
    /// <summary>
    /// Universal transfer type
    /// </summary>
    public required Type7 Type { get; init; }

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

    /// <summary>
    /// Default:10 Max:100
    /// </summary>
    public int? Size { get; init; }

    /// <summary>
    /// Must be sent when type are ISOLATEDMARGIN_MARGIN and ISOLATEDMARGIN_ISOLATEDMARGIN
    /// </summary>
    public string? FromSymbol { get; init; }

    /// <summary>
    /// Must be sent when type are MARGIN_ISOLATEDMARGIN and ISOLATEDMARGIN_ISOLATEDMARGIN
    /// </summary>
    public string? ToSymbol { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
