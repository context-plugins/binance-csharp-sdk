using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1LendingAutoInvestRedeemResponse
{
    [JsonPropertyName("redemptionId")]
    public required long RedemptionId { get; init; }
}
