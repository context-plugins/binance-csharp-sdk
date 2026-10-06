using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1BlvtTokenInfoResponse
{
    [JsonPropertyName("tokenName")]
    public required string TokenName { get; init; }

    [JsonPropertyName("description")]
    public required string Description { get; init; }

    [JsonPropertyName("underlying")]
    public required string Underlying { get; init; }

    [JsonPropertyName("tokenIssued")]
    public required string TokenIssued { get; init; }

    [JsonPropertyName("basket")]
    public required string Basket { get; init; }

    [JsonPropertyName("currentBaskets")]
    public required IReadOnlyList<CurrentBasket> CurrentBaskets { get; init; }

    [JsonPropertyName("nav")]
    public required string Nav { get; init; }

    [JsonPropertyName("realLeverage")]
    public required string RealLeverage { get; init; }

    [JsonPropertyName("fundingRate")]
    public required string FundingRate { get; init; }

    [JsonPropertyName("dailyManagementFee")]
    public required string DailyManagementFee { get; init; }

    [JsonPropertyName("purchaseFeePct")]
    public required string PurchaseFeePct { get; init; }

    [JsonPropertyName("dailyPurchaseLimit")]
    public required string DailyPurchaseLimit { get; init; }

    [JsonPropertyName("redeemFeePct")]
    public required string RedeemFeePct { get; init; }

    [JsonPropertyName("dailyRedeemLimit")]
    public required string DailyRedeemLimit { get; init; }

    [JsonPropertyName("timestamp")]
    public required long Timestamp { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
