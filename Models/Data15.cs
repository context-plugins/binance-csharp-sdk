using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Data15
{
    [JsonPropertyName("configDetails")]
    public required IReadOnlyList<ConfigDetail> ConfigDetails { get; init; }

    [JsonPropertyName("totalNum")]
    public required long TotalNum { get; init; }

    [JsonPropertyName("pageSize")]
    public required long PageSize { get; init; }
}
