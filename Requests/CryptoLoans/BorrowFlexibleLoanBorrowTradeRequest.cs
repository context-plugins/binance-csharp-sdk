namespace Binance.Requests.CryptoLoans;

/// <summary>
/// The inputs of the BorrowFlexibleLoanBorrowTrade operation.
/// </summary>
public sealed record BorrowFlexibleLoanBorrowTradeRequest
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
    /// Coin loaned
    /// </summary>
    public string? LoanCoin { get; init; }

    /// <summary>
    /// Loan amount
    /// </summary>
    public double? LoanAmount { get; init; }

    /// <summary>
    /// Coin used as collateral
    /// </summary>
    public string? CollateralCoin { get; init; }

    public double? CollateralAmount { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
