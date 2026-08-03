using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1NftHistoryTransactionsResponse
{
    [JsonPropertyName("total")]
    public required int Total { get; init; }

    [JsonPropertyName("list")]
    public required IReadOnlyList<List3> List { get; init; }
}
