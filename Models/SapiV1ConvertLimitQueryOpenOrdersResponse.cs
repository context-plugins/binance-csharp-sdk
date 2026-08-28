using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1ConvertLimitQueryOpenOrdersResponse
{
    [JsonPropertyName("list")]
    public required IReadOnlyList<List1> List { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
