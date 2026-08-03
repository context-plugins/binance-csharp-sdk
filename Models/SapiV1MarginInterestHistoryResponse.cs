using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1MarginInterestHistoryResponse
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row3> Rows { get; init; }

    [JsonPropertyName("total")]
    public required int Total { get; init; }
}
