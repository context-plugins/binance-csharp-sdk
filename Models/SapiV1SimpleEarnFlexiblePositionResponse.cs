using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SimpleEarnFlexiblePositionResponse
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row40> Rows { get; init; }

    [JsonPropertyName("total")]
    public required long Total { get; init; }
}
