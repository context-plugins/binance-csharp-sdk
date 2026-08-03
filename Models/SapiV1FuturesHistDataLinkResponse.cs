using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1FuturesHistDataLinkResponse
{
    [JsonPropertyName("data")]
    public required IReadOnlyList<Data20> Data { get; init; }
}
