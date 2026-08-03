using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV2LoanFlexibleLtvAdjustmentHistoryResponse
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row28> Rows { get; init; }

    [JsonPropertyName("total")]
    public required int Total { get; init; }
}
