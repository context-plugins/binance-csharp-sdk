using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1LendingAutoInvestRedeemResponse
{
    [JsonPropertyName("redemptionId")]
    public required long RedemptionId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
