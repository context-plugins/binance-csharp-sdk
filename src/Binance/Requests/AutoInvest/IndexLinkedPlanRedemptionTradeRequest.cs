namespace Binance.Requests.AutoInvest;

/// <summary>
/// The inputs of the IndexLinkedPlanRedemptionTrade operation.
/// </summary>
public sealed record IndexLinkedPlanRedemptionTradeRequest
{
    /// <summary>
    /// PORTFOLIO plan's Id
    /// </summary>
    public required long IndexId { get; init; }

    /// <summary>
    /// user redeem percentage,10/20/100.
    /// </summary>
    public required int RedemptionPercentage { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// sourceType + unique, transactionId and requestId cannot be empty at the same time
    /// </summary>
    public string? RequestId { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
