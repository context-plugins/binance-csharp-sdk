using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Data31
{
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("baseAsset")]
    public required string BaseAsset { get; init; }

    [JsonPropertyName("quoteAsset")]
    public required string QuoteAsset { get; init; }
}
