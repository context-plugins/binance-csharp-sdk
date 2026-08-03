using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1MarginLeverageBracketResponse
{
    [JsonPropertyName("assetNames")]
    public required IReadOnlyList<string> AssetNames { get; init; }

    [JsonPropertyName("rank")]
    public required int Rank { get; init; }

    [JsonPropertyName("brackets")]
    public required IReadOnlyList<Bracket> Brackets { get; init; }
}
