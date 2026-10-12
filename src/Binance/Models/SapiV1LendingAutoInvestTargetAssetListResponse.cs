using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1LendingAutoInvestTargetAssetListResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("targetAssets")]
    public string? TargetAssets { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autoInvestAssetList")]
    public IReadOnlyList<AutoInvestAssetList>? AutoInvestAssetList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
