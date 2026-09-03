using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Plan
{
    [JsonPropertyName("planId")]
    public required int PlanId { get; init; }

    [JsonPropertyName("planType")]
    public required string PlanType { get; init; }

    [JsonPropertyName("editAllowed")]
    public required string EditAllowed { get; init; }

    [JsonPropertyName("creationDateTime")]
    public required long CreationDateTime { get; init; }

    [JsonPropertyName("firstExecutionDateTime")]
    public required long FirstExecutionDateTime { get; init; }

    [JsonPropertyName("nextExecutionDateTime")]
    public required long NextExecutionDateTime { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("lastUpdatedDateTime")]
    public required long LastUpdatedDateTime { get; init; }

    [JsonPropertyName("targetAsset")]
    public required string TargetAsset { get; init; }

    [JsonPropertyName("totalTargetAmount")]
    public required string TotalTargetAmount { get; init; }

    [JsonPropertyName("sourceAsset")]
    public required string SourceAsset { get; init; }

    [JsonPropertyName("totalInvestedInUSD")]
    public required string TotalInvestedInUsd { get; init; }

    [JsonPropertyName("subscriptionAmount")]
    public required string SubscriptionAmount { get; init; }

    [JsonPropertyName("subscriptionCycle")]
    public required string SubscriptionCycle { get; init; }

    [JsonPropertyName("subscriptionStartDay")]
    public required string SubscriptionStartDay { get; init; }

    [JsonPropertyName("subscriptionStartWeekday")]
    public required string SubscriptionStartWeekday { get; init; }

    [JsonPropertyName("subscriptionStartTime")]
    public required string SubscriptionStartTime { get; init; }

    [JsonPropertyName("sourceWallet")]
    public required string SourceWallet { get; init; }

    [JsonPropertyName("flexibleAllowedToUse")]
    public required string FlexibleAllowedToUse { get; init; }

    [JsonPropertyName("planValueInUSD")]
    public required string PlanValueInUsd { get; init; }

    [JsonPropertyName("pnlInUSD")]
    public required string PnlInUsd { get; init; }

    [JsonPropertyName("roi")]
    public required string Roi { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
