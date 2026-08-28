using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Row38
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("latestAnnualPercentageRate")]
    public required string LatestAnnualPercentageRate { get; init; }

    [JsonPropertyName("tierAnnualPercentageRate")]
    public required TierAnnualPercentageRate TierAnnualPercentageRate { get; init; }

    [JsonPropertyName("airDropPercentageRate")]
    public required string AirDropPercentageRate { get; init; }

    [JsonPropertyName("canPurchase")]
    public required bool CanPurchase { get; init; }

    [JsonPropertyName("canRedeem")]
    public required bool CanRedeem { get; init; }

    [JsonPropertyName("isSoldOut")]
    public required bool IsSoldOut { get; init; }

    [JsonPropertyName("hot")]
    public required bool Hot { get; init; }

    [JsonPropertyName("minPurchaseAmount")]
    public required string MinPurchaseAmount { get; init; }

    [JsonPropertyName("productId")]
    public required string ProductId { get; init; }

    [JsonPropertyName("subscriptionStartTime")]
    public required string SubscriptionStartTime { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
