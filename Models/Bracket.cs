using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Bracket
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("leverage")]
    public int? Leverage { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxDebt")]
    public double? MaxDebt { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maintenanceMarginRate")]
    public double? MaintenanceMarginRate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("initialMarginRate")]
    public double? InitialMarginRate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fastNum")]
    public double? FastNum { get; init; }
}
