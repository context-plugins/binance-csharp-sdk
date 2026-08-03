using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record ApiV3UserDataStreamResponse
{
    [JsonPropertyName("listenKey")]
    public required string ListenKey { get; init; }
}
