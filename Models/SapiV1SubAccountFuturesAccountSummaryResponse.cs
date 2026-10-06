using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1SubAccountFuturesAccountSummaryResponse
{
    [JsonPropertyName("totalInitialMargin")]
    public required string TotalInitialMargin { get; init; }

    [JsonPropertyName("totalMaintenanceMargin")]
    public required string TotalMaintenanceMargin { get; init; }

    [JsonPropertyName("totalMarginBalance")]
    public required string TotalMarginBalance { get; init; }

    [JsonPropertyName("totalOpenOrderInitialMargin")]
    public required string TotalOpenOrderInitialMargin { get; init; }

    [JsonPropertyName("totalPositionInitialMargin")]
    public required string TotalPositionInitialMargin { get; init; }

    [JsonPropertyName("totalUnrealizedProfit")]
    public required string TotalUnrealizedProfit { get; init; }

    [JsonPropertyName("totalWalletBalance")]
    public required string TotalWalletBalance { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("subAccountList")]
    public required IReadOnlyList<SubAccountList3> SubAccountList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
