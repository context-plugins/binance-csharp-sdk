using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Balance2
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("free")]
    public required long Free { get; init; }

    [JsonPropertyName("locked")]
    public required long Locked { get; init; }
}
