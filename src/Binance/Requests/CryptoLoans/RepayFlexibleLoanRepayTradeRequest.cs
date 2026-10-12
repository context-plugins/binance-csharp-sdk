namespace Binance.Requests.CryptoLoans;

/// <summary>
/// The inputs of the RepayFlexibleLoanRepayTrade operation.
/// </summary>
public sealed record RepayFlexibleLoanRepayTradeRequest
{
    /// <summary>
    /// repay amount of loanCoin
    /// </summary>
    public required double RepayAmount { get; init; }

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
    /// Coin used as collateral
    /// </summary>
    public string? CollateralCoin { get; init; }

    /// <summary>
    /// Default: TRUE.
    /// TRUE: Return extra collateral to earn account;
    /// FALSE: Keep extra collateral in the order, and lower LTV.
    /// </summary>
    public bool? CollateralReturn { get; init; }

    /// <summary>
    /// Default: FALSE.
    /// TRUE: Full repayment;
    /// FALSE: Partial repayment, based on loanAmount
    /// </summary>
    public bool? FullRepayment { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
