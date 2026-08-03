using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV2LoanFlexibleBorrowHistoryResponse
{
    [JsonPropertyName("total")]
    public required int Total { get; init; }

    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row26> Rows { get; init; }
}
