using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record MarginTrade
{
    [JsonPropertyName("commission")]
    public required string Commission { get; init; }

    [JsonPropertyName("commissionAsset")]
    public required string CommissionAsset { get; init; }

    [JsonPropertyName("id")]
    public required long Id { get; init; }

    [JsonPropertyName("isBestMatch")]
    public required bool IsBestMatch { get; init; }

    [JsonPropertyName("isBuyer")]
    public required bool IsBuyer { get; init; }

    [JsonPropertyName("isMaker")]
    public required bool IsMaker { get; init; }

    [JsonPropertyName("orderId")]
    public required long OrderId { get; init; }

    [JsonPropertyName("price")]
    public required string Price { get; init; }

    [JsonPropertyName("qty")]
    public required string Qty { get; init; }

    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("isIsolated")]
    public required bool IsIsolated { get; init; }

    [JsonPropertyName("time")]
    public required long Time { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
