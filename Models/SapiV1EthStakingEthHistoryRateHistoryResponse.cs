using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1EthStakingEthHistoryRateHistoryResponse
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row34> Rows { get; init; }

    [JsonPropertyName("total")]
    public required long Total { get; init; }
}
