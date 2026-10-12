using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1ConvertTradeFlowResponse
{
    [JsonPropertyName("list")]
    public required IReadOnlyList<List2> List { get; init; }

    [JsonPropertyName("startTime")]
    public required long StartTime { get; init; }

    [JsonPropertyName("endTime")]
    public required long EndTime { get; init; }

    [JsonPropertyName("limit")]
    public required int Limit { get; init; }

    [JsonPropertyName("moreData")]
    public required bool MoreData { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
