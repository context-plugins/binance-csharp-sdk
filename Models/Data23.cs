using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Data23
{
    [JsonPropertyName("page")]
    public required int Page { get; init; }

    [JsonPropertyName("totalRecords")]
    public required int TotalRecords { get; init; }

    [JsonPropertyName("totalPageNum")]
    public required int TotalPageNum { get; init; }

    [JsonPropertyName("data")]
    public required IReadOnlyList<Data24> Data { get; init; }
}
