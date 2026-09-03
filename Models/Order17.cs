using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Order17
{
    [JsonPropertyName("algoId")]
    public required int AlgoId { get; init; }

    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("side")]
    public required string Side { get; init; }

    [JsonPropertyName("totalQty")]
    public required string TotalQty { get; init; }

    [JsonPropertyName("executedQty")]
    public required string ExecutedQty { get; init; }

    [JsonPropertyName("executedAmt")]
    public required string ExecutedAmt { get; init; }

    [JsonPropertyName("avgPrice")]
    public required string AvgPrice { get; init; }

    [JsonPropertyName("clientAlgoId")]
    public required string ClientAlgoId { get; init; }

    [JsonPropertyName("bookTime")]
    public required long BookTime { get; init; }

    [JsonPropertyName("endTime")]
    public required long EndTime { get; init; }

    [JsonPropertyName("algoStatus")]
    public required string AlgoStatus { get; init; }

    [JsonPropertyName("algoType")]
    public required string AlgoType { get; init; }

    [JsonPropertyName("urgency")]
    public required string Urgency { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
