using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1LendingAutoInvestPlanAddResponse
{
    [JsonPropertyName("planId")]
    public required int PlanId { get; init; }

    [JsonPropertyName("nextExecutionDateTime")]
    public required long NextExecutionDateTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
