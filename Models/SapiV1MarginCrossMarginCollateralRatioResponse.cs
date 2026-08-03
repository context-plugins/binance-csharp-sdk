using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1MarginCrossMarginCollateralRatioResponse
{
    [JsonPropertyName("collaterals")]
    public required IReadOnlyList<Collateral> Collaterals { get; init; }

    [JsonPropertyName("assetNames")]
    public required IReadOnlyList<string> AssetNames { get; init; }
}
