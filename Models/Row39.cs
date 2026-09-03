using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Row39
{
    [JsonPropertyName("projectId")]
    public required string ProjectId { get; init; }

    [JsonPropertyName("detail")]
    public required Detail6 Detail { get; init; }

    [JsonPropertyName("quota")]
    public required Quota Quota { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
