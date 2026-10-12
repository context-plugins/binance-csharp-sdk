namespace Binance.Requests.Savings;

/// <summary>
/// The inputs of the PurchaseFixedActivityProjectUserData operation.
/// </summary>
public sealed record PurchaseFixedActivityProjectUserDataRequest
{
    public required string ProjectId { get; init; }

    public required string Lot { get; init; }

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
