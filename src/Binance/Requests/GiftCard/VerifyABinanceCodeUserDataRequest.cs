namespace Binance.Requests.GiftCard;

/// <summary>
/// The inputs of the VerifyABinanceCodeUserData operation.
/// </summary>
public sealed record VerifyABinanceCodeUserDataRequest
{
    /// <summary>
    /// reference number
    /// </summary>
    public required string ReferenceNo { get; init; }

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
