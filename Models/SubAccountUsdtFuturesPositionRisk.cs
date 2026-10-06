using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SubAccountUsdtFuturesPositionRisk
{
    [JsonPropertyName("futurePositionRiskVos")]
    public required IReadOnlyList<FuturePositionRiskVo> FuturePositionRiskVos { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
