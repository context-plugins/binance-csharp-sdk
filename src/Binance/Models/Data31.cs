using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Data31
{
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("baseAsset")]
    public required string BaseAsset { get; init; }

    [JsonPropertyName("quoteAsset")]
    public required string QuoteAsset { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
