using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1EthStakingEthQuotaResponse
{
    /// <summary>
    /// Show min(Daily available limit, total personal staking quota)
    /// </summary>
    [JsonPropertyName("leftStakingPersonalQuota")]
    public required string LeftStakingPersonalQuota { get; init; }

    /// <summary>
    /// Show min(Daily personal redeem quota, total redemption limit)
    /// </summary>
    [JsonPropertyName("leftRedemptionPersonalQuota")]
    public required string LeftRedemptionPersonalQuota { get; init; }
}
