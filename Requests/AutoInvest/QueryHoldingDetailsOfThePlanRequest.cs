namespace Binance.Requests.AutoInvest;

/// <summary>
/// The inputs of the QueryHoldingDetailsOfThePlan operation.
/// </summary>
public sealed record QueryHoldingDetailsOfThePlanRequest
{
    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    public long? PlanId { get; init; }

    public string? RequestId { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
