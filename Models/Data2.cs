using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Data2
{
    [JsonPropertyName("assets")]
    public required IReadOnlyList<Asset1> Assets { get; init; }

    [JsonPropertyName("position")]
    public required IReadOnlyList<Position> Position { get; init; }
}
