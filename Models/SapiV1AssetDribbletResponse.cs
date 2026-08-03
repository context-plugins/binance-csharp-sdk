using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1AssetDribbletResponse
{
    /// <summary>
    /// Total counts of exchange
    /// </summary>
    [JsonPropertyName("total")]
    public required long Total { get; init; }

    [JsonPropertyName("userAssetDribblets")]
    public required IReadOnlyList<UserAssetDribblet> UserAssetDribblets { get; init; }
}
