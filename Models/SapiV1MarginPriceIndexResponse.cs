using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1MarginPriceIndexResponse
{
    [JsonPropertyName("calcTime")]
    public required long CalcTime { get; init; }

    [JsonPropertyName("price")]
    public required string Price { get; init; }

    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }
}
