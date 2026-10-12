using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1LendingAutoInvestAllAssetResponse
{
    [JsonPropertyName("targetAssets")]
    public required IReadOnlyList<string> TargetAssets { get; init; }

    [JsonPropertyName("sourceAssets")]
    public required IReadOnlyList<string> SourceAssets { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
