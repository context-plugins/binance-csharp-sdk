using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record MarginTransferDetails
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row> Rows { get; init; }

    [JsonPropertyName("total")]
    public required int Total { get; init; }
}
