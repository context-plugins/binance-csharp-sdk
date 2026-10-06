namespace Binance.Requests.VipLoans;

/// <summary>
/// The inputs of the GetBorrowInterestRateUserData operation.
/// </summary>
public sealed record GetBorrowInterestRateUserDataRequest
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
    /// Max 10 assets, Multiple split by ","
    /// </summary>
    public string? LoanCoin { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
