using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Data20
{
    [JsonPropertyName("day")]
    public required string Day { get; init; }

    [JsonPropertyName("url")]
    public required string Url { get; init; }
}
