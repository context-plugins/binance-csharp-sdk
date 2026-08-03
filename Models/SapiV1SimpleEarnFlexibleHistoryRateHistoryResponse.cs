using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SimpleEarnFlexibleHistoryRateHistoryResponse
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row48> Rows { get; init; }

    [JsonPropertyName("total")]
    public required long Total { get; init; }
}
