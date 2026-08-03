using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Row39
{
    [JsonPropertyName("projectId")]
    public required string ProjectId { get; init; }

    [JsonPropertyName("detail")]
    public required Detail6 Detail { get; init; }

    [JsonPropertyName("quota")]
    public required Quota Quota { get; init; }
}
