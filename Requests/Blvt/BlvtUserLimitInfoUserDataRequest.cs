namespace Binance.Requests.Blvt;

/// <summary>
/// The inputs of the BlvtUserLimitInfoUserData operation.
/// </summary>
public sealed record BlvtUserLimitInfoUserDataRequest
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
    /// BTCDOWN, BTCUP
    /// </summary>
    public string? TokenName { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
