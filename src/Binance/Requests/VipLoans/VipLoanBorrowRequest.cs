using Binance.Models.Enums;

namespace Binance.Requests.VipLoans;

/// <summary>
/// The inputs of the VipLoanBorrow operation.
/// </summary>
public sealed record VipLoanBorrowRequest
{
    public required long LoanAccountId { get; init; }

    public required double LoanAmount { get; init; }

    public required string CollateralAccountId { get; init; }

    public required string CollateralCoin { get; init; }

    public required IsFlexibleRate IsFlexibleRate { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// Coin loaned
    /// </summary>
    public string? LoanCoin { get; init; }

    public int? LoanTerm { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
