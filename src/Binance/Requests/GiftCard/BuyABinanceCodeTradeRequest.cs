namespace Binance.Requests.GiftCard;

/// <summary>
/// The inputs of the BuyABinanceCodeTrade operation.
/// </summary>
public sealed record BuyABinanceCodeTradeRequest
{
    /// <summary>
    /// The token you want to pay, example BUSD
    /// </summary>
    public required string BaseToken { get; init; }

    /// <summary>
    /// The token you want to buy, example BNB. If faceToken = baseToken, it's the same as createCode endpoint.
    /// </summary>
    public required string FaceToken { get; init; }

    /// <summary>
    /// The base token asset quantity, example  1.002
    /// </summary>
    public required double BaseTokenAmount { get; init; }

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
