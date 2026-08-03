using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV2LoanFlexibleOngoingOrdersResponse
{
    [JsonPropertyName("total")]
    public required int Total { get; init; }

    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row25> Rows { get; init; }
}
