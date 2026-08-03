using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV2PortfolioCollateralRateResponse
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("collateralInfo")]
    public required IReadOnlyList<CollateralInfo> CollateralInfo { get; init; }
}
