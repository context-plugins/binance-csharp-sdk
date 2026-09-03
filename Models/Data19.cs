using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Data19
{
    [JsonPropertyName("accountProfits")]
    public required IReadOnlyList<AccountProfit1> AccountProfits { get; init; }

    [JsonPropertyName("totalNum")]
    public required int TotalNum { get; init; }

    [JsonPropertyName("pageSize")]
    public required int PageSize { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
