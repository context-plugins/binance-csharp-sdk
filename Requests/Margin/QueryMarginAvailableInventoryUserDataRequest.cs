using Binance.Models.Enums;

namespace Binance.Requests.Margin;

/// <summary>
/// The inputs of the QueryMarginAvailableInventoryUserData operation.
/// </summary>
public sealed record QueryMarginAvailableInventoryUserDataRequest
{
    public required Type4 Type { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }
}
