using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1AlgoFuturesHistoricalOrdersResponse
{
    [JsonPropertyName("total")]
    public required int Total { get; init; }

    [JsonPropertyName("orders")]
    public required IReadOnlyList<Order15> Orders { get; init; }
}
