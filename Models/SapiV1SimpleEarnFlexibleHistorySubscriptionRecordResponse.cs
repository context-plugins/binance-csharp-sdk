using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SimpleEarnFlexibleHistorySubscriptionRecordResponse
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row42> Rows { get; init; }

    [JsonPropertyName("total")]
    public required long Total { get; init; }
}
