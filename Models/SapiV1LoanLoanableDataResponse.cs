using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1LoanLoanableDataResponse
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row22> Rows { get; init; }

    [JsonPropertyName("total")]
    public required int Total { get; init; }
}
