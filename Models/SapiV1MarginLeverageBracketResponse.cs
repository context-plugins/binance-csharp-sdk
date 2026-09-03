using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1MarginLeverageBracketResponse
{
    [JsonPropertyName("assetNames")]
    public required IReadOnlyList<string> AssetNames { get; init; }

    [JsonPropertyName("rank")]
    public required int Rank { get; init; }

    [JsonPropertyName("brackets")]
    public required IReadOnlyList<Bracket> Brackets { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
