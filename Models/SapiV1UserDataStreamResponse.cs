using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1UserDataStreamResponse
{
    [JsonPropertyName("listenKey")]
    public required string ListenKey { get; init; }
}
