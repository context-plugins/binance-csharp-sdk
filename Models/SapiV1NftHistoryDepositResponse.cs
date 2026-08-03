using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1NftHistoryDepositResponse
{
    [JsonPropertyName("total")]
    public required int Total { get; init; }

    [JsonPropertyName("list")]
    public required IReadOnlyList<List4> List { get; init; }
}
