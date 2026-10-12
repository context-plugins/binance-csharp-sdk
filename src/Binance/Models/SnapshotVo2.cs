using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SnapshotVo2
{
    [JsonPropertyName("data")]
    public required Data2 Data { get; init; }

    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("updateTime")]
    public required long UpdateTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
