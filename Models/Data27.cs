using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Data27
{
    [JsonPropertyName("valid")]
    public required bool Valid { get; init; }

    [JsonPropertyName("token")]
    public required string Token { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }
}
