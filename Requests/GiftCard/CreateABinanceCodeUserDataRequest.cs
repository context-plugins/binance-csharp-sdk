namespace Binance.Requests.GiftCard;

/// <summary>
/// The inputs of the CreateABinanceCodeUserData operation.
/// </summary>
public sealed record CreateABinanceCodeUserDataRequest
{
    /// <summary>
    /// The coin type contained in the Binance Code
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// The amount of the coin
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
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
