namespace Binance.Requests.PortfolioMargin;

/// <summary>
/// The inputs of the QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserData operation.
/// </summary>
public sealed record QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataRequest
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
    /// UTC timestamp in ms
    /// </summary>
    public long? StartTime { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public long? EndTime { get; init; }

    /// <summary>
    /// Default:10 Max:100
    /// </summary>
    public int? Size { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
