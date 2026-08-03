using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1ManagedSubaccountQueryTransLogForInvestorResponse
{
    [JsonPropertyName("count")]
    public required int Count { get; init; }

    [JsonPropertyName("managerSubTransferHistoryVos")]
    public required IReadOnlyList<ManagerSubTransferHistoryVo> ManagerSubTransferHistoryVos { get; init; }
}
