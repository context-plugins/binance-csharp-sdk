namespace Binance.Requests.PortfolioMargin;

/// <summary>
/// The inputs of the PortfolioMarginAccountUserData operation.
/// </summary>
public sealed record PortfolioMarginAccountUserDataRequest
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
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
