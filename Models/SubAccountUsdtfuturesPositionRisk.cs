using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SubAccountUsdtfuturesPositionRisk
{
    [JsonPropertyName("futurePositionRiskVos")]
    public required IReadOnlyList<FuturePositionRiskVo> FuturePositionRiskVos { get; init; }
}
