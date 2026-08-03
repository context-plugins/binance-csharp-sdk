using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1LendingAutoInvestPlanAddResponse
{
    [JsonPropertyName("planId")]
    public required int PlanId { get; init; }

    [JsonPropertyName("nextExecutionDateTime")]
    public required long NextExecutionDateTime { get; init; }
}
