namespace Binance.Requests.Wallet;

/// <summary>
/// The inputs of the ConvertTransferUserData operation.
/// </summary>
public sealed record ConvertTransferUserDataRequest
{
    /// <summary>
    /// The unique flag, the min length is 20
    /// </summary>
    public required string ClientTranId { get; init; }

    public required string Asset { get; init; }

    public required double Amount { get; init; }

    /// <summary>
    /// Target asset you want to convert
    /// </summary>
    public required string TargetAsset { get; init; }

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
