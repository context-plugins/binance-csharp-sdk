using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1MarginBorrowRepayResponse1
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row1> Rows { get; init; }

    [JsonPropertyName("total")]
    public required int Total { get; init; }
}
