using Binance.Models.Enums;

namespace Binance.Requests.DualInvestment;

/// <summary>
/// The inputs of the ChangeAutoCompoundStatusUserData operation.
/// </summary>
public sealed record ChangeAutoCompoundStatusUserDataRequest
{
    /// <summary>
    /// Get positionId from /sapi/v1/dci/product/positions
    /// </summary>
    public required long PositionId { get; init; }

    /// <summary>
    /// NONE: switch off the plan,
    /// STANDARD: standard plan,
    /// ADVANCED: advanced plan;
    /// </summary>
    public required AutoCompoundPlan AutoCompoundPlan { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
