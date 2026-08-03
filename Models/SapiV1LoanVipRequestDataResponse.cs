using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1LoanVipRequestDataResponse
{
    [JsonPropertyName("total")]
    public required int Total { get; init; }

    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row17> Rows { get; init; }
}
