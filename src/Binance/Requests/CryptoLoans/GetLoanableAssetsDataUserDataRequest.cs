namespace Binance.Requests.CryptoLoans;

/// <summary>
/// The inputs of the GetLoanableAssetsDataUserData operation.
/// </summary>
public sealed record GetLoanableAssetsDataUserDataRequest
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
    /// Defaults to user's vip level
    /// </summary>
    public int? VipLevel { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
