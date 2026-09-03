using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record DeliveryPositionRiskVo
{
    [JsonPropertyName("entryPrice")]
    public required string EntryPrice { get; init; }

    [JsonPropertyName("markPrice")]
    public required string MarkPrice { get; init; }

    [JsonPropertyName("leverage")]
    public required string Leverage { get; init; }

    [JsonPropertyName("isolated")]
    public required string Isolated { get; init; }

    [JsonPropertyName("isolatedWallet")]
    public required string IsolatedWallet { get; init; }

    [JsonPropertyName("isolatedMargin")]
    public required string IsolatedMargin { get; init; }

    [JsonPropertyName("isAutoAddMargin")]
    public required string IsAutoAddMargin { get; init; }

    [JsonPropertyName("positionSide")]
    public required string PositionSide { get; init; }

    [JsonPropertyName("positionAmount")]
    public required string PositionAmount { get; init; }

    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("unrealizedProfit")]
    public required string UnrealizedProfit { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
