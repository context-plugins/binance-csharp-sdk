using Binance.Models.Enums;

namespace Binance.Requests.CryptoLoans;

/// <summary>
/// The inputs of the GetCryptoLoansIncomeHistoryUserData operation.
/// </summary>
public sealed record GetCryptoLoansIncomeHistoryUserDataRequest
{
    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    public string? Asset { get; init; }

    /// <summary>
    /// All types will be returned by default.
    ///   * <c>borrowIn</c>
    ///   * <c>collateralSpent</c>
    ///   * <c>repayAmount</c>
    ///   * <c>collateralReturn</c> - Collateral return after repayment
    ///   * <c>addCollateral</c>
    ///   * <c>removeCollateral</c>
    ///   * <c>collateralReturnAfterLiquidation</c>
    /// </summary>
    public Type9? Type { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? StartTime { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? EndTime { get; init; }

    /// <summary>
    /// default 20, max 100
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
