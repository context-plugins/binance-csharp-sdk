using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1LendingAutoInvestSourceAssetListResponse
{
    [JsonPropertyName("feeRate")]
    public required string FeeRate { get; init; }

    [JsonPropertyName("sourceAssets")]
    public required IReadOnlyList<SourceAsset> SourceAssets { get; init; }
}
