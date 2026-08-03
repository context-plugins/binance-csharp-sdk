using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1AlgoSpotOpenOrdersResponse
{
    [JsonPropertyName("total")]
    public required long Total { get; init; }

    [JsonPropertyName("orders")]
    public required IReadOnlyList<Order17> Orders { get; init; }
}
