using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Data6
{
    [JsonPropertyName("assets")]
    public required IReadOnlyList<Assets2> Assets { get; init; }

    [JsonPropertyName("position")]
    public required IReadOnlyList<Position1> Position { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
