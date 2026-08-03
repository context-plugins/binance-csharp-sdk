using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SubAccountCoinfuturesPositionRisk
{
    [JsonPropertyName("deliveryPositionRiskVos")]
    public required IReadOnlyList<DeliveryPositionRiskVo> DeliveryPositionRiskVos { get; init; }
}
