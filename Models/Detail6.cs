using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Detail6
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("rewardAsset")]
    public required string RewardAsset { get; init; }

    [JsonPropertyName("duration")]
    public required long Duration { get; init; }

    [JsonPropertyName("renewable")]
    public required bool Renewable { get; init; }

    [JsonPropertyName("isSoldOut")]
    public required bool IsSoldOut { get; init; }

    [JsonPropertyName("apr")]
    public required string Apr { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("subscriptionStartTime")]
    public required string SubscriptionStartTime { get; init; }

    [JsonPropertyName("extraRewardAsset")]
    public required string ExtraRewardAsset { get; init; }

    [JsonPropertyName("extraRewardAPR")]
    public required string ExtraRewardApr { get; init; }
}
