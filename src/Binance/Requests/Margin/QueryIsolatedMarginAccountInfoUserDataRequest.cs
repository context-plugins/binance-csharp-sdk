namespace Binance.Requests.Margin;

/// <summary>
/// The inputs of the QueryIsolatedMarginAccountInfoUserData operation.
/// </summary>
public sealed record QueryIsolatedMarginAccountInfoUserDataRequest
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
    /// Max 5 symbols can be sent; separated by ','
    /// </summary>
    public string? Symbols { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
