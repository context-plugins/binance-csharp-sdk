using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1UserDataStreamIsolatedResponse
{
    [JsonPropertyName("listenKey")]
    public required string ListenKey { get; init; }
}
