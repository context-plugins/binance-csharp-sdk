using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1LendingAutoInvestIndexUserSummaryResponse
{
    [JsonPropertyName("indexId")]
    public required long IndexId { get; init; }

    [JsonPropertyName("totalInvestedInUSD")]
    public required string TotalInvestedInUsd { get; init; }

    /// <summary>
    /// current invest
    /// </summary>
    [JsonPropertyName("currentInvestedInUSD")]
    public required string CurrentInvestedInUsd { get; init; }

    /// <summary>
    /// PNL of the plan in USD based on current amount
    /// </summary>
    [JsonPropertyName("pnlInUSD")]
    public required string PnlInUsd { get; init; }

    /// <summary>
    /// ROI of the plan based on current amount
    /// </summary>
    [JsonPropertyName("roi")]
    public required string Roi { get; init; }

    [JsonPropertyName("assetAllocation")]
    public required IReadOnlyList<AssetAllocation1> AssetAllocation { get; init; }

    [JsonPropertyName("details")]
    public required IReadOnlyList<Detail4> Details { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
