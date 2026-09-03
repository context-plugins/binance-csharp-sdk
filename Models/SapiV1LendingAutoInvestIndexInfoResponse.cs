using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1LendingAutoInvestIndexInfoResponse
{
    [JsonPropertyName("indexId")]
    public required long IndexId { get; init; }

    [JsonPropertyName("indexName")]
    public required string IndexName { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("assetAllocation")]
    public required IReadOnlyList<AssetAllocation> AssetAllocation { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
