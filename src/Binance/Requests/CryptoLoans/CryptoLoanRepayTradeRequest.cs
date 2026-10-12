namespace Binance.Requests.CryptoLoans;

/// <summary>
/// The inputs of the CryptoLoanRepayTrade operation.
/// </summary>
public sealed record CryptoLoanRepayTradeRequest
{
    /// <summary>
    /// Order ID
    /// </summary>
    public required long OrderId { get; init; }

    /// <summary>
    /// Repayment Amount
    /// </summary>
    public required double Amount { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// Default: 1. 1 for 'repay with borrowed coin'; 2 for 'repay with collateral'.
    /// </summary>
    public int? Type { get; init; }

    /// <summary>
    /// Default: TRUE. TRUE: Return extra collateral to spot account; FALSE: Keep extra collateral in the order.
    /// </summary>
    public bool? CollateralReturn { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
