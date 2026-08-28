using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record List7
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("investCoin")]
    public required string InvestCoin { get; init; }

    [JsonPropertyName("exercisedCoin")]
    public required string ExercisedCoin { get; init; }

    [JsonPropertyName("strikePrice")]
    public required string StrikePrice { get; init; }

    [JsonPropertyName("duration")]
    public required int Duration { get; init; }

    [JsonPropertyName("settleDate")]
    public required long SettleDate { get; init; }

    [JsonPropertyName("purchaseDecimal")]
    public required int PurchaseDecimal { get; init; }

    [JsonPropertyName("purchaseEndTime")]
    public required long PurchaseEndTime { get; init; }

    [JsonPropertyName("canPurchase")]
    public required bool CanPurchase { get; init; }

    [JsonPropertyName("apr")]
    public required string Apr { get; init; }

    [JsonPropertyName("orderId")]
    public required long OrderId { get; init; }

    [JsonPropertyName("minAmount")]
    public required string MinAmount { get; init; }

    [JsonPropertyName("maxAmount")]
    public required string MaxAmount { get; init; }

    [JsonPropertyName("createTimestamp")]
    public required long CreateTimestamp { get; init; }

    [JsonPropertyName("optionType")]
    public required string OptionType { get; init; }

    [JsonPropertyName("isAutoCompoundEnable")]
    public required bool IsAutoCompoundEnable { get; init; }

    [JsonPropertyName("autoCompoundPlanList")]
    public required IReadOnlyList<string> AutoCompoundPlanList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
