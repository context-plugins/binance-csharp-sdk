using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1SubAccountSpotSummaryResponse
{
    [JsonPropertyName("totalCount")]
    public required long TotalCount { get; init; }

    [JsonPropertyName("masterAccountTotalAsset")]
    public required string MasterAccountTotalAsset { get; init; }

    [JsonPropertyName("spotSubUserAssetBtcVoList")]
    public required IReadOnlyList<SpotSubUserAssetBtcVoList> SpotSubUserAssetBtcVoList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
