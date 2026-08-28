using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1LendingAutoInvestPlanListResponse
{
    [JsonPropertyName("planValueInUSD")]
    public required string PlanValueInUsd { get; init; }

    [JsonPropertyName("planValueInBTC")]
    public required string PlanValueInBtc { get; init; }

    [JsonPropertyName("pnlInUSD")]
    public required string PnlInUsd { get; init; }

    [JsonPropertyName("roi")]
    public required string Roi { get; init; }

    [JsonPropertyName("plan")]
    public required IReadOnlyList<Plan> Plan { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
