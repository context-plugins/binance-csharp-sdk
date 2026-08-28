using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1SimpleEarnLockedHistorySubscriptionRecordResponse
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row43> Rows { get; init; }

    [JsonPropertyName("total")]
    public required long Total { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
