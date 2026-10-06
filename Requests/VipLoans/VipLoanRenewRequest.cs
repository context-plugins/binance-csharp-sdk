namespace Binance.Requests.VipLoans;

/// <summary>
/// The inputs of the VipLoanRenew operation.
/// </summary>
public sealed record VipLoanRenewRequest
{
    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// Order id
    /// </summary>
    public long? OrderId { get; init; }

    public int? LoanTerm { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
