using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1LoanVipRepayHistoryResponse
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row13> Rows { get; init; }

    [JsonPropertyName("total")]
    public required int Total { get; init; }
}
