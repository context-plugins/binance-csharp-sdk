using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1MarginAvailableInventoryResponse
{
    [JsonPropertyName("assets")]
    public required Assets Assets { get; init; }

    [JsonPropertyName("updateTime")]
    public required long UpdateTime { get; init; }
}
