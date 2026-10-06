using Binance.Models.Enums;

namespace Binance.Requests.Margin;

/// <summary>
/// The inputs of the ToggleBnbBurnOnSpotTradeAndMarginInterestUserData operation.
/// </summary>
public sealed record ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataRequest
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
    /// Determines whether to use BNB to pay for trading fees on SPOT
    /// </summary>
    public SpotBnbBurn? SpotBnbBurn { get; init; }

    /// <summary>
    /// Determines whether to use BNB to pay for margin loan's interest
    /// </summary>
    public InterestBnbBurn? InterestBnbBurn { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
