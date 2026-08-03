using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1AccountApiRestrictionsResponse
{
    [JsonPropertyName("ipRestrict")]
    public required bool IpRestrict { get; init; }

    [JsonPropertyName("createTime")]
    public required long CreateTime { get; init; }

    /// <summary>
    /// This option authorizes this key to transfer funds between your master account and your sub account instantly
    /// </summary>
    [JsonPropertyName("enableInternalTransfer")]
    public required bool EnableInternalTransfer { get; init; }

    /// <summary>
    /// API Key created before your futures account opened does not support futures API service
    /// </summary>
    [JsonPropertyName("enableFutures")]
    public required bool EnableFutures { get; init; }

    /// <summary>
    /// API Key created before your activate portfolio margin does not support portfolio margin API service
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enablePortfolioMarginTrading")]
    public bool? EnablePortfolioMarginTrading { get; init; }

    /// <summary>
    /// Authorizes this key to Vanilla options trading
    /// </summary>
    [JsonPropertyName("enableVanillaOptions")]
    public required bool EnableVanillaOptions { get; init; }

    /// <summary>
    /// Authorizes this key to be used for a dedicated universal transfer API to transfer multiple supported currencies. Each business's own transfer API rights are not affected by this authorization
    /// </summary>
    [JsonPropertyName("permitsUniversalTransfer")]
    public required bool PermitsUniversalTransfer { get; init; }

    [JsonPropertyName("enableReading")]
    public required bool EnableReading { get; init; }

    [JsonPropertyName("enableSpotAndMarginTrading")]
    public required bool EnableSpotAndMarginTrading { get; init; }

    /// <summary>
    /// This option allows you to withdraw via API. You must apply the IP Access Restriction filter in order to enable withdrawals
    /// </summary>
    [JsonPropertyName("enableWithdrawals")]
    public required bool EnableWithdrawals { get; init; }

    /// <summary>
    /// This option can be adjusted after the Cross Margin account transfer is completed
    /// </summary>
    [JsonPropertyName("enableMargin")]
    public required bool EnableMargin { get; init; }

    /// <summary>
    /// Expiration time for spot and margin trading permission
    /// </summary>
    [JsonPropertyName("tradingAuthorityExpirationTime")]
    public required long TradingAuthorityExpirationTime { get; init; }
}
