using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Data13
{
    [JsonPropertyName("accountProfits")]
    public required IReadOnlyList<AccountProfit> AccountProfits { get; init; }

    /// <summary>
    /// Total Rows
    /// </summary>
    [JsonPropertyName("totalNum")]
    public required long TotalNum { get; init; }

    /// <summary>
    /// Rows per page
    /// </summary>
    [JsonPropertyName("pageSize")]
    public required long PageSize { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
