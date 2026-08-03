using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV2LoanFlexibleCollateralDataResponse
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row30> Rows { get; init; }

    [JsonPropertyName("total")]
    public required int Total { get; init; }
}
