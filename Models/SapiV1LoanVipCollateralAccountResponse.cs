using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1LoanVipCollateralAccountResponse
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row14> Rows { get; init; }

    [JsonPropertyName("total")]
    public required int Total { get; init; }
}
