using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1ManagedSubaccountQueryTransLogResponse
{
    [JsonPropertyName("count")]
    public required int Count { get; init; }

    [JsonPropertyName("managerSubTransferHistoryVos")]
    public required IReadOnlyList<ManagerSubTransferHistoryVo2> ManagerSubTransferHistoryVos { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
