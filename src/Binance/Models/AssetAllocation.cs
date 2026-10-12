using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record AssetAllocation
{
    [JsonPropertyName("targetAsset")]
    public required string TargetAsset { get; init; }

    [JsonPropertyName("allocation")]
    public required string Allocation { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
