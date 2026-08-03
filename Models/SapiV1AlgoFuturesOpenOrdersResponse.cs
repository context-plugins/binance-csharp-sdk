using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1AlgoFuturesOpenOrdersResponse
{
    [JsonPropertyName("total")]
    public required int Total { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orders")]
    public IReadOnlyList<Order15>? Orders { get; init; }
}
