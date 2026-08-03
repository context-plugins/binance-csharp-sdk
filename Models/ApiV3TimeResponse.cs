using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record ApiV3TimeResponse
{
    [JsonPropertyName("serverTime")]
    public required long ServerTime { get; init; }
}
