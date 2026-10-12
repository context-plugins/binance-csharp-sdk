namespace Binance.Requests.GiftCard;

/// <summary>
/// The inputs of the FetchTokenLimitUserData operation.
/// </summary>
public sealed record FetchTokenLimitUserDataRequest
{
    /// <summary>
    /// The token you want to pay, example BUSD
    /// </summary>
    public required string BaseToken { get; init; }

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
