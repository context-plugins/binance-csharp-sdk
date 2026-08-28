using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1AlgoSpotHistoricalOrdersResponse
{
    [JsonPropertyName("total")]
    public required long Total { get; init; }

    [JsonPropertyName("orders")]
    public required IReadOnlyList<Order17> Orders { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
