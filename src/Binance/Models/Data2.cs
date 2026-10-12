using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Data2
{
    [JsonPropertyName("assets")]
    public required IReadOnlyList<Asset1> Assets { get; init; }

    [JsonPropertyName("position")]
    public required IReadOnlyList<Position> Position { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
