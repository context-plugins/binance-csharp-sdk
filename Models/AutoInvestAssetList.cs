using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record AutoInvestAssetList
{
    [JsonPropertyName("targetAsset")]
    public required string TargetAsset { get; init; }

    [JsonPropertyName("roiAndDimensionTypeList")]
    public required IReadOnlyList<RoiAndDimensionTypeList> RoiAndDimensionTypeList { get; init; }
}
