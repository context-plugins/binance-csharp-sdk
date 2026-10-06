namespace Binance.Requests.CryptoLoans;

/// <summary>
/// The inputs of the GetCollateralAssetsDataUserData operation.
/// </summary>
public sealed record GetCollateralAssetsDataUserDataRequest
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
    /// Coin used as collateral
    /// </summary>
    public string? CollateralCoin { get; init; }

    /// <summary>
    /// Defaults to user's vip level
    /// </summary>
    public int? VipLevel { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
