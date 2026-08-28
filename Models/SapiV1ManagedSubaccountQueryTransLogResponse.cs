using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1ManagedSubaccountQueryTransLogResponse
{
    [JsonPropertyName("count")]
    public required int Count { get; init; }

    [JsonPropertyName("managerSubTransferHistoryVos")]
    public required IReadOnlyList<ManagerSubTransferHistoryVo2> ManagerSubTransferHistoryVos { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
