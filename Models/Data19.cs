using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Data19
{
    [JsonPropertyName("accountProfits")]
    public required IReadOnlyList<AccountProfit1> AccountProfits { get; init; }

    [JsonPropertyName("totalNum")]
    public required int TotalNum { get; init; }

    [JsonPropertyName("pageSize")]
    public required int PageSize { get; init; }
}
