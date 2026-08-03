using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1MiningWorkerDetailResponse
{
    [JsonPropertyName("code")]
    public required long Code { get; init; }

    [JsonPropertyName("msg")]
    public required string Msg { get; init; }

    [JsonPropertyName("data")]
    public required IReadOnlyList<Data11> Data { get; init; }
}
