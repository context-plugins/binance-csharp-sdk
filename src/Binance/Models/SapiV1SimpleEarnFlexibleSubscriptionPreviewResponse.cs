using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1SimpleEarnFlexibleSubscriptionPreviewResponse
{
    [JsonPropertyName("totalAmount")]
    public required string TotalAmount { get; init; }

    [JsonPropertyName("rewardAsset")]
    public required string RewardAsset { get; init; }

    [JsonPropertyName("airDropAsset")]
    public required string AirDropAsset { get; init; }

    [JsonPropertyName("estDailyBonusRewards")]
    public required string EstDailyBonusRewards { get; init; }

    [JsonPropertyName("estDailyRealTimeRewards")]
    public required string EstDailyRealTimeRewards { get; init; }

    [JsonPropertyName("estDailyAirdropRewards")]
    public required string EstDailyAirdropRewards { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
