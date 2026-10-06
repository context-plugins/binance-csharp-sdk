using Binance.Models.Enums;

namespace Binance.Requests.Savings;

/// <summary>
/// The inputs of the GetFixedActivityProjectListUserData operation.
/// </summary>
public sealed record GetFixedActivityProjectListUserDataRequest
{
    public required Type8 Type { get; init; }

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
    /// Default <c>ALL</c>
    /// </summary>
    public Status? Status { get; init; }

    /// <summary>
    /// default "true"
    /// </summary>
    public bool? IsSortAsc { get; init; }

    /// <summary>
    /// Default <c>START_TIME</c>
    /// </summary>
    public SortBy? SortBy { get; init; }

    /// <summary>
    /// Current querying page. Start from 1. Default:1
    /// </summary>
    public int? Current { get; init; }

    /// <summary>
    /// Default:10 Max:100
    /// </summary>
    public int? Size { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
