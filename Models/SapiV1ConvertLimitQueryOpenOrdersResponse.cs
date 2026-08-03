using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1ConvertLimitQueryOpenOrdersResponse
{
    [JsonPropertyName("list")]
    public required IReadOnlyList<List1> List { get; init; }
}
