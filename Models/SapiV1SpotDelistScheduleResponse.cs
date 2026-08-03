using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SpotDelistScheduleResponse
{
    [JsonPropertyName("delistTime")]
    public required long DelistTime { get; init; }

    [JsonPropertyName("symbol")]
    public required IReadOnlyList<string> Symbol { get; init; }
}
