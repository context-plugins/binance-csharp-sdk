using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1LendingAutoInvestSourceAssetListResponse
{
    [JsonPropertyName("feeRate")]
    public required string FeeRate { get; init; }

    [JsonPropertyName("sourceAssets")]
    public required IReadOnlyList<SourceAsset> SourceAssets { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
