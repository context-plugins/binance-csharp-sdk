namespace Binance.Requests.Margin;

/// <summary>
/// The inputs of the GetSummaryOfMarginAccountUserData operation.
/// </summary>
public sealed record GetSummaryOfMarginAccountUserDataRequest
{
    /// <summary>
    /// Email Address
    /// </summary>
    public required string Email { get; init; }

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
