using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1AccountStatusResponse
{
    [JsonPropertyName("data")]
    public required string Data { get; init; }
}
