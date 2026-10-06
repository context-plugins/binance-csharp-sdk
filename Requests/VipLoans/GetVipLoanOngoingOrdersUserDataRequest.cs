namespace Binance.Requests.VipLoans;

/// <summary>
/// The inputs of the GetVipLoanOngoingOrdersUserData operation.
/// </summary>
public sealed record GetVipLoanOngoingOrdersUserDataRequest
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

    public long? CollateralAccountId { get; init; }

    /// <summary>
    /// Coin loaned
    /// </summary>
    public string? LoanCoin { get; init; }

    /// <summary>
    /// Coin used as collateral
    /// </summary>
    public string? CollateralCoin { get; init; }

    /// <summary>
    /// Current querying page. Start from 1. Default:1
    /// </summary>
    public int? Current { get; init; }

    /// <summary>
    /// Default 10; max 100.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
