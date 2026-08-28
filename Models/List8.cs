using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record List8
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("investCoin")]
    public required string InvestCoin { get; init; }

    [JsonPropertyName("exercisedCoin")]
    public required string ExercisedCoin { get; init; }

    [JsonPropertyName("subscriptionAmount")]
    public required string SubscriptionAmount { get; init; }

    [JsonPropertyName("strikePrice")]
    public required string StrikePrice { get; init; }

    [JsonPropertyName("duration")]
    public required int Duration { get; init; }

    [JsonPropertyName("settleDate")]
    public required long SettleDate { get; init; }

    [JsonPropertyName("purchaseStatus")]
    public required string PurchaseStatus { get; init; }

    [JsonPropertyName("apr")]
    public required string Apr { get; init; }

    [JsonPropertyName("orderId")]
    public required long OrderId { get; init; }

    [JsonPropertyName("purchaseEndTime")]
    public required long PurchaseEndTime { get; init; }

    [JsonPropertyName("optionType")]
    public required string OptionType { get; init; }

    [JsonPropertyName("autoCompoundPlan")]
    public required string AutoCompoundPlan { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
