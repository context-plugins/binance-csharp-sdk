using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Data16
{
    [JsonPropertyName("profitTransferDetails")]
    public required IReadOnlyList<ProfitTransferDetail> ProfitTransferDetails { get; init; }

    [JsonPropertyName("totalNum")]
    public required long TotalNum { get; init; }

    [JsonPropertyName("pageSize")]
    public required long PageSize { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
