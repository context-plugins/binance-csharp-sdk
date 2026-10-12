using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Row45
{
    [JsonPropertyName("positionId")]
    public required string PositionId { get; init; }

    [JsonPropertyName("redeemId")]
    public required long RedeemId { get; init; }

    [JsonPropertyName("time")]
    public required long Time { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("lockPeriod")]
    public required string LockPeriod { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("originalAmount")]
    public required string OriginalAmount { get; init; }

    /// <summary>
    /// MATURE for redeem to Spot Wallet, NEW_TRANSFERRED for redeem to Flexible product, AHEAD for early redemption
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("deliverDate")]
    public required string DeliverDate { get; init; }

    /// <summary>
    /// Loss of profit on early redemption
    /// </summary>
    [JsonPropertyName("lossAmount")]
    public required string LossAmount { get; init; }

    [JsonPropertyName("isComplete")]
    public required bool IsComplete { get; init; }

    [JsonPropertyName("rewardAsset")]
    public required string RewardAsset { get; init; }

    [JsonPropertyName("rewardAmt")]
    public required string RewardAmt { get; init; }

    [JsonPropertyName("extraRewardAsset")]
    public required string ExtraRewardAsset { get; init; }

    [JsonPropertyName("estExtraRewardAmt")]
    public required string EstExtraRewardAmt { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
