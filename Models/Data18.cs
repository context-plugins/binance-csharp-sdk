using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Data18
{
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("userName")]
    public required string UserName { get; init; }

    [JsonPropertyName("list")]
    public required IReadOnlyList<ListModel> List { get; init; }
}
