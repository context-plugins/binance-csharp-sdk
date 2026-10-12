namespace Binance.Requests.CryptoLoans;

/// <summary>
/// The inputs of the CryptoLoanCustomizeMarginCallTrade operation.
/// </summary>
public sealed record CryptoLoanCustomizeMarginCallTradeRequest
{
    public required double MarginCall { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// Mandatory when collateralCoin is empty. Send either orderId or collateralCoin, if both parameters are sent, take orderId only.
    /// </summary>
    public long? OrderId { get; init; }

    /// <summary>
    /// Coin used as collateral
    /// </summary>
    public string? CollateralCoin { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
