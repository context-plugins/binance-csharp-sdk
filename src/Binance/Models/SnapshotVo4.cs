using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SnapshotVo4
{
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("updateTime")]
    public required long UpdateTime { get; init; }

    [JsonPropertyName("data")]
    public required Data6 Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
