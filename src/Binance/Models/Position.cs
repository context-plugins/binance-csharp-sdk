using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Position
{
    [JsonPropertyName("entryPrice")]
    public required string EntryPrice { get; init; }

    [JsonPropertyName("markPrice")]
    public required string MarkPrice { get; init; }

    [JsonPropertyName("positionAmt")]
    public required string PositionAmt { get; init; }

    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("unRealizedProfit")]
    public required string UnRealizedProfit { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
