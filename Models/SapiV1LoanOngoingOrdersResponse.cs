using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1LoanOngoingOrdersResponse
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row19> Rows { get; init; }

    [JsonPropertyName("total")]
    public required int Total { get; init; }
}
