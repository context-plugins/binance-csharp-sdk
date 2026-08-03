using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1LoanVipCollateralDataResponse
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row16> Rows { get; init; }

    [JsonPropertyName("total")]
    public required int Total { get; init; }
}
