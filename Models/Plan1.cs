using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Plan1
{
    [JsonPropertyName("planId")]
    public required int PlanId { get; init; }

    [JsonPropertyName("planType")]
    public required string PlanType { get; init; }

    [JsonPropertyName("editAllowed")]
    public required string EditAllowed { get; init; }

    [JsonPropertyName("flexibleAllowedToUse")]
    public required string FlexibleAllowedToUse { get; init; }

    [JsonPropertyName("creationDateTime")]
    public required long CreationDateTime { get; init; }

    [JsonPropertyName("firstExecutionDateTime")]
    public required long FirstExecutionDateTime { get; init; }

    [JsonPropertyName("nextExecutionDateTime")]
    public required long NextExecutionDateTime { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("targetAsset")]
    public required string TargetAsset { get; init; }

    [JsonPropertyName("sourceAsset")]
    public required string SourceAsset { get; init; }

    [JsonPropertyName("totalInvestedInUSD")]
    public required string TotalInvestedInUsd { get; init; }

    [JsonPropertyName("planValueInUSD")]
    public required string PlanValueInUsd { get; init; }

    [JsonPropertyName("pnlInUSD")]
    public required string PnlInUsd { get; init; }

    [JsonPropertyName("roi")]
    public required string Roi { get; init; }

    [JsonPropertyName("details")]
    public required IReadOnlyList<Detail3> Details { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
