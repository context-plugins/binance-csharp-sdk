using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Row46
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("rewards")]
    public required string Rewards { get; init; }

    [JsonPropertyName("projectId")]
    public required string ProjectId { get; init; }

    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("time")]
    public required long Time { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
