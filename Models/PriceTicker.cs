using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record PriceTicker
{
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("price")]
    public required string Price { get; init; }
}
