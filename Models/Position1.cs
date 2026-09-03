using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Position1
{
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("entryPrice")]
    public required double EntryPrice { get; init; }

    [JsonPropertyName("markPrice")]
    public required double MarkPrice { get; init; }

    [JsonPropertyName("positionAmt")]
    public required double PositionAmt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
