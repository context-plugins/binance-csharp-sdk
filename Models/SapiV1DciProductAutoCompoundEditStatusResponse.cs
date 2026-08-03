using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1DciProductAutoCompoundEditStatusResponse
{
    [JsonPropertyName("positionId")]
    public required string PositionId { get; init; }

    /// <summary>
    /// NONE, STANDARD, ADVANCED
    /// </summary>
    [JsonPropertyName("autoCompoundPlan")]
    public required string AutoCompoundPlan { get; init; }
}
