using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1AssetCustodyTransferHistoryResponse
{
    [JsonPropertyName("total")]
    public required int Total { get; init; }

    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row10> Rows { get; init; }
}
