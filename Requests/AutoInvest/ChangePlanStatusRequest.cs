using Binance.Models.Enums;

namespace Binance.Requests.AutoInvest;

/// <summary>
/// The inputs of the ChangePlanStatus operation.
/// </summary>
public sealed record ChangePlanStatusRequest
{
    public required int PlanId { get; init; }

    public required Status1 Status { get; init; }

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
