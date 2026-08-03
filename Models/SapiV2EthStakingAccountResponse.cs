using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV2EthStakingAccountResponse
{
    [JsonPropertyName("holdingInETH")]
    public required string HoldingInEth { get; init; }

    [JsonPropertyName("holdings")]
    public required Holdings Holdings { get; init; }

    [JsonPropertyName("thirtyDaysProfitInETH")]
    public required string ThirtyDaysProfitInEth { get; init; }

    [JsonPropertyName("profit")]
    public required Profit Profit { get; init; }
}
