using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SubAccountCoinFuturesPositionRisk
{
    [JsonPropertyName("deliveryPositionRiskVos")]
    public required IReadOnlyList<DeliveryPositionRiskVo> DeliveryPositionRiskVos { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
