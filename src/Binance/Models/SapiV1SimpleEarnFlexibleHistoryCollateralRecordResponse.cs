using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1SimpleEarnFlexibleHistoryCollateralRecordResponse
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row49> Rows { get; init; }

    [JsonPropertyName("total")]
    public required long Total { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
