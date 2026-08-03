using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1EthStakingEthHistoryRedemptionHistoryResponse
{
    [JsonPropertyName("rows")]
    public required IReadOnlyList<Row32> Rows { get; init; }

    [JsonPropertyName("total")]
    public required long Total { get; init; }
}
