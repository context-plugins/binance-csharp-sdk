namespace Binance.Requests.CryptoLoans;

/// <summary>
/// The inputs of the CheckCollateralRepayRateUserData operation.
/// </summary>
public sealed record CheckCollateralRepayRateUserDataRequest
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
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
