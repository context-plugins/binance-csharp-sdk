using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1BlvtUserLimitResponse
{
    [JsonPropertyName("tokenName")]
    public required string TokenName { get; init; }

    /// <summary>
    /// USDT
    /// </summary>
    [JsonPropertyName("userDailyTotalPurchaseLimit")]
    public required string UserDailyTotalPurchaseLimit { get; init; }

    /// <summary>
    /// USDT
    /// </summary>
    [JsonPropertyName("userDailyTotalRedeemLimit")]
    public required string UserDailyTotalRedeemLimit { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
