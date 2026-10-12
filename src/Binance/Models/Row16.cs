using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Row16
{
    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    [JsonPropertyName("_1stCollateralRatio")]
    public required string StCollateralRatio1 { get; init; }

    [JsonPropertyName("_1stCollateralRange")]
    public required string StCollateralRange1 { get; init; }

    [JsonPropertyName("_2ndCollateralRatio")]
    public required string NdCollateralRatio2 { get; init; }

    [JsonPropertyName("_2ndCollateralRange")]
    public required string NdCollateralRange2 { get; init; }

    [JsonPropertyName("_3rdCollateralRatio")]
    public required string RdCollateralRatio3 { get; init; }

    [JsonPropertyName("_3rdCollateralRange")]
    public required string RdCollateralRange3 { get; init; }

    [JsonPropertyName("_4thCollateralRatio")]
    public required string ThCollateralRatio4 { get; init; }

    [JsonPropertyName("_4thCollateralRange")]
    public required string ThCollateralRange4 { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
