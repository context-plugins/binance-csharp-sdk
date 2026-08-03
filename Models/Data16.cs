using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Data16
{
    [JsonPropertyName("profitTransferDetails")]
    public required IReadOnlyList<ProfitTransferDetail> ProfitTransferDetails { get; init; }

    [JsonPropertyName("totalNum")]
    public required long TotalNum { get; init; }

    [JsonPropertyName("pageSize")]
    public required long PageSize { get; init; }
}
