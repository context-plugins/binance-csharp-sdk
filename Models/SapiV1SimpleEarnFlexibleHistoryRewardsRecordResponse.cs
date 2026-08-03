using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SimpleEarnFlexibleHistoryRewardsRecordResponse
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row46> Rows { get; init; }

    [JsonPropertyName("total")]
    public required long Total { get; init; }
}
