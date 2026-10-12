using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record PriceTicker
{
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("price")]
    public required string Price { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
