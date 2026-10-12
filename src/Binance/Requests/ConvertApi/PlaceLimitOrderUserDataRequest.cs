using Binance.Models.Enums;

namespace Binance.Requests.ConvertApi;

/// <summary>
/// The inputs of the PlaceLimitOrderUserData operation.
/// </summary>
public sealed record PlaceLimitOrderUserDataRequest
{
    public required string BaseAsset { get; init; }

    public required string QuoteAsset { get; init; }

    /// <summary>
    /// Symbol limit price (from baseAsset to quoteAsset)
    /// </summary>
    public required double LimitPrice { get; init; }

    public required Side Side { get; init; }

    /// <summary>
    /// UTC timestamp in ms
    /// </summary>
    public required long Timestamp { get; init; }

    /// <summary>
    /// Signature
    /// </summary>
    public required string Signature { get; init; }

    /// <summary>
    /// Base asset amount. (One of baseAmount or quoteAmount is required)
    /// </summary>
    public double? BaseAmount { get; init; }

    /// <summary>
    /// Quote asset amount. (One of baseAmount or quoteAmount is required)
    /// </summary>
    public double? QuoteAmount { get; init; }

    /// <summary>
    /// SPOT or FUNDING or SPOT_FUNDING. It is to use which type of assets. Default is SPOT.
    /// </summary>
    public WalletType? WalletType { get; init; }

    /// <summary>
    /// 1_D, 3_D, 7_D, 30_D (D means day)
    /// </summary>
    public ExpiredType? ExpiredType { get; init; }

    /// <summary>
    /// The value cannot be greater than 60000
    /// </summary>
    public long? RecvWindow { get; init; }
}
