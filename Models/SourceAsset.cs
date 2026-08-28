using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SourceAsset
{
    [JsonPropertyName("sourceAsset")]
    public required string SourceAssetValue { get; init; }

    [JsonPropertyName("assetMinAmount")]
    public required string AssetMinAmount { get; init; }

    [JsonPropertyName("assetMaxAmount")]
    public required string AssetMaxAmount { get; init; }

    [JsonPropertyName("scale")]
    public required string Scale { get; init; }

    [JsonPropertyName("flexibleAmount")]
    public required string FlexibleAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
