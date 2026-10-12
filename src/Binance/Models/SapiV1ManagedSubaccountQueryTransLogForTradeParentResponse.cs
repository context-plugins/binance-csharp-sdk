using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse
{
    [JsonPropertyName("count")]
    public required int Count { get; init; }

    [JsonPropertyName("managerSubTransferHistoryVos")]
    public required IReadOnlyList<ManagerSubTransferHistoryVo> ManagerSubTransferHistoryVos { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
