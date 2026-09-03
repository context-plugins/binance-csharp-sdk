using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1LendingAutoInvestPlanEditResponse
{
    [JsonPropertyName("planId")]
    public required int PlanId { get; init; }

    [JsonPropertyName("nextExecutionDateTime")]
    public required long NextExecutionDateTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
