namespace Binance.Requests.CryptoLoans;

/// <summary>
/// The inputs of the CryptoLoanBorrowTrade operation.
/// </summary>
public sealed record CryptoLoanBorrowTradeRequest
{
    /// <summary>
    /// Coin loaned
    /// </summary>
    public required string LoanCoin { get; init; }

    /// <summary>
    /// Coin used as collateral
    /// </summary>
    public required string CollateralCoin { get; init; }

    /// <summary>
    /// 7/14/30/90/180 days
    /// </summary>
    public required int LoanTerm { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// Loan amount
    /// </summary>
    public double? LoanAmount { get; init; }

    public double? CollateralAmount { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
