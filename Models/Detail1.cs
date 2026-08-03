using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Detail1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("targetAsset")]
    public string? TargetAsset { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("percentage")]
    public long? Percentage { get; init; }
}
