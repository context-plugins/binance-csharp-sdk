namespace Binance.Requests.CryptoLoans;

/// <summary>
/// The inputs of the GetFlexibleLoanAssetsDataUserData operation.
/// </summary>
public sealed record GetFlexibleLoanAssetsDataUserDataRequest
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
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
