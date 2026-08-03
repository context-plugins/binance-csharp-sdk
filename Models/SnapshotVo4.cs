using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SnapshotVo4
{
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("updateTime")]
    public required long UpdateTime { get; init; }

    [JsonPropertyName("data")]
    public required Data6 Data { get; init; }
}
