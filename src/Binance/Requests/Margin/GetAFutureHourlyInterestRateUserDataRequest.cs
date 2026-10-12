using Binance.Models.Enums;

namespace Binance.Requests.Margin;

/// <summary>
/// The inputs of the GetAFutureHourlyInterestRateUserData operation.
/// </summary>
public sealed record GetAFutureHourlyInterestRateUserDataRequest
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
    /// List of assets, separated by commas, up to 20
    /// </summary>
    public string? Assets { get; init; }

    /// <summary>
    /// for isolated margin or not, "TRUE", "FALSE"
    /// </summary>
    public IsIsolated? IsIsolated { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
