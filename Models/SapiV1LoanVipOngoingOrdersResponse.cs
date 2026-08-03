using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1LoanVipOngoingOrdersResponse
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row12> Rows { get; init; }

    [JsonPropertyName("total")]
    public required int Total { get; init; }
}
