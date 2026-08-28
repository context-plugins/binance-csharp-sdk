using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1AlgoFuturesSubOrdersResponse
{
    [JsonPropertyName("total")]
    public required int Total { get; init; }

    [JsonPropertyName("executedQty")]
    public required string ExecutedQty { get; init; }

    [JsonPropertyName("executedAmt")]
    public required string ExecutedAmt { get; init; }

    [JsonPropertyName("subOrders")]
    public required IReadOnlyList<SubOrder> SubOrders { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
