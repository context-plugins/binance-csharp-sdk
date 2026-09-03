using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SubAccountUsdtFuturesPositionRisk
{
    [JsonPropertyName("futurePositionRiskVos")]
    public required IReadOnlyList<FuturePositionRiskVo> FuturePositionRiskVos { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
