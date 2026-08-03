using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1MarginDelistScheduleResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delistTime")]
    public long? DelistTime { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("crossMarginAssets")]
    public IReadOnlyList<string>? CrossMarginAssets { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isolatedMarginSymbols")]
    public IReadOnlyList<string>? IsolatedMarginSymbols { get; init; }
}
