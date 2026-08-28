using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Quota
{
    [JsonPropertyName("totalPersonalQuota")]
    public required string TotalPersonalQuota { get; init; }

    [JsonPropertyName("minimum")]
    public required string Minimum { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
