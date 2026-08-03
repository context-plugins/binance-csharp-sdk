using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1DciProductListResponse
{
    [JsonPropertyName("total")]
    public required long Total { get; init; }

    [JsonPropertyName("list")]
    public required IReadOnlyList<List7> List { get; init; }
}
