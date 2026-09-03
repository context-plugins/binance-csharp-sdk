using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record ApiV3MyPreventedMatchesResponse
{
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("preventedMatchId")]
    public required long PreventedMatchId { get; init; }

    [JsonPropertyName("takerOrderId")]
    public required long TakerOrderId { get; init; }

    [JsonPropertyName("makerOrderId")]
    public required long MakerOrderId { get; init; }

    [JsonPropertyName("tradeGroupId")]
    public required long TradeGroupId { get; init; }

    [JsonPropertyName("selfTradePreventionMode")]
    public required string SelfTradePreventionMode { get; init; }

    [JsonPropertyName("price")]
    public required string Price { get; init; }

    [JsonPropertyName("makerPreventedQuantity")]
    public required string MakerPreventedQuantity { get; init; }

    [JsonPropertyName("transactTime")]
    public required long TransactTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
