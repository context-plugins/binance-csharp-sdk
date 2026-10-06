namespace Binance.Requests.Margin;

/// <summary>
/// The inputs of the QueryMaxBorrowUserData operation.
/// </summary>
public sealed record QueryMaxBorrowUserDataRequest
{
    public required string Asset { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// Isolated symbol
    /// </summary>
    public string? IsolatedSymbol { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
