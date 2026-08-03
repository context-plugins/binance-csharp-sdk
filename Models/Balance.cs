using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Balance
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("free")]
    public required string Free { get; init; }

    [JsonPropertyName("locked")]
    public required string Locked { get; init; }
}
