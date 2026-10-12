using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1AssetDribbletResponse
{
    /// <summary>
    /// Total counts of exchange
    /// </summary>
    [JsonPropertyName("total")]
    public required long Total { get; init; }

    [JsonPropertyName("userAssetDribblets")]
    public required IReadOnlyList<UserAssetDribblet> UserAssetDribblets { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
