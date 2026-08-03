using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SimpleEarnLockedSubscriptionPreviewResponse
{
    [JsonPropertyName("rewardAsset")]
    public required string RewardAsset { get; init; }

    [JsonPropertyName("totalRewardAmt")]
    public required string TotalRewardAmt { get; init; }

    [JsonPropertyName("extraRewardAsset")]
    public required string ExtraRewardAsset { get; init; }

    [JsonPropertyName("estTotalExtraRewardAmt")]
    public required string EstTotalExtraRewardAmt { get; init; }

    [JsonPropertyName("nextPay")]
    public required string NextPay { get; init; }

    [JsonPropertyName("nextPayDate")]
    public required string NextPayDate { get; init; }

    [JsonPropertyName("valueDate")]
    public required string ValueDate { get; init; }

    [JsonPropertyName("rewardsEndDate")]
    public required string RewardsEndDate { get; init; }

    [JsonPropertyName("deliverDate")]
    public required string DeliverDate { get; init; }

    [JsonPropertyName("nextSubscriptionDate")]
    public required string NextSubscriptionDate { get; init; }
}
