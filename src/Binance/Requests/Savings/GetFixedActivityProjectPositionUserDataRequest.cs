using Binance.Models.Enums;

namespace Binance.Requests.Savings;

/// <summary>
/// The inputs of the GetFixedActivityProjectPositionUserData operation.
/// </summary>
public sealed record GetFixedActivityProjectPositionUserDataRequest
{
    public required string Asset { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    public string? ProjectId { get; init; }

    /// <summary>
    /// Default <c>ALL</c>
    /// </summary>
    public Status? Status { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
