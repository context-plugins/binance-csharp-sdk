using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV2LoanFlexibleLoanableDataResponse
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row29> Rows { get; init; }

    [JsonPropertyName("total")]
    public required int Total { get; init; }
}
