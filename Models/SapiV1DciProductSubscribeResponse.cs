using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1DciProductSubscribeResponse
{
    [JsonPropertyName("positionId")]
    public required long PositionId { get; init; }

    [JsonPropertyName("investCoin")]
    public required string InvestCoin { get; init; }

    [JsonPropertyName("exercisedCoin")]
    public required string ExercisedCoin { get; init; }

    [JsonPropertyName("subscriptionAmount")]
    public required string SubscriptionAmount { get; init; }

    [JsonPropertyName("duration")]
    public required int Duration { get; init; }

    /// <summary>
    /// STANDARD, ADVANCED, this field won't display when autocompound is set to None
    /// </summary>
    [JsonPropertyName("autoCompoundPlan")]
    public required string AutoCompoundPlan { get; init; }

    [JsonPropertyName("strikePrice")]
    public required string StrikePrice { get; init; }

    [JsonPropertyName("settleDate")]
    public required long SettleDate { get; init; }

    [JsonPropertyName("purchaseStatus")]
    public required string PurchaseStatus { get; init; }

    [JsonPropertyName("apr")]
    public required string Apr { get; init; }

    [JsonPropertyName("orderId")]
    public required long OrderId { get; init; }

    [JsonPropertyName("purchaseTime")]
    public required long PurchaseTime { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("optionType\"")]
    public string? OptionType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
