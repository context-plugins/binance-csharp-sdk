using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1MarginForceLiquidationRecResponse
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row4> Rows { get; init; }

    [JsonPropertyName("total")]
    public required int Total { get; init; }
}
