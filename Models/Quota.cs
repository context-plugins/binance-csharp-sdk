using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Quota
{
    [JsonPropertyName("totalPersonalQuota")]
    public required string TotalPersonalQuota { get; init; }

    [JsonPropertyName("minimum")]
    public required string Minimum { get; init; }
}
