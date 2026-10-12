using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1SimpleEarnFlexibleListResponse
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row38> Rows { get; init; }

    [JsonPropertyName("total")]
    public required long Total { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
