using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1DciProductListResponse
{
    [JsonPropertyName("total")]
    public required long Total { get; init; }

    [JsonPropertyName("list")]
    public required IReadOnlyList<List7> List { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
