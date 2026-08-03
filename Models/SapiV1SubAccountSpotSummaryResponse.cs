using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SubAccountSpotSummaryResponse
{
    [JsonPropertyName("totalCount")]
    public required long TotalCount { get; init; }

    [JsonPropertyName("masterAccountTotalAsset")]
    public required string MasterAccountTotalAsset { get; init; }

    [JsonPropertyName("spotSubUserAssetBtcVoList")]
    public required IReadOnlyList<SpotSubUserAssetBtcVoList> SpotSubUserAssetBtcVoList { get; init; }
}
