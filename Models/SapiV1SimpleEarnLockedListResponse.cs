using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SimpleEarnLockedListResponse
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row39> Rows { get; init; }

    [JsonPropertyName("total")]
    public required long Total { get; init; }
}
