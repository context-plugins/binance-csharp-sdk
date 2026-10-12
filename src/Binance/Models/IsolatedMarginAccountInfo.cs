using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record IsolatedMarginAccountInfo
{
    [JsonPropertyName("assets")]
    public required IReadOnlyList<Asset> Assets { get; init; }

    [JsonPropertyName("totalAssetOfBtc")]
    public required string TotalAssetOfBtc { get; init; }

    [JsonPropertyName("totalLiabilityOfBtc")]
    public required string TotalLiabilityOfBtc { get; init; }

    [JsonPropertyName("totalNetAssetOfBtc")]
    public required string TotalNetAssetOfBtc { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
