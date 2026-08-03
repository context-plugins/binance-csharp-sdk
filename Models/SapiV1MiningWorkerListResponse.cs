using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1MiningWorkerListResponse
{
    [JsonPropertyName("code")]
    public required long Code { get; init; }

    [JsonPropertyName("msg")]
    public required string Msg { get; init; }

    [JsonPropertyName("data")]
    public required Data12 Data { get; init; }
}
