using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1LoanBorrowHistoryResponse
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row18> Rows { get; init; }

    [JsonPropertyName("total")]
    public required int Total { get; init; }
}
