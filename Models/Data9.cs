using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Data9
{
    [JsonPropertyName("algoName")]
    public required string AlgoName { get; init; }

    [JsonPropertyName("algoId")]
    public required long AlgoId { get; init; }

    [JsonPropertyName("poolIndex")]
    public required long PoolIndex { get; init; }

    [JsonPropertyName("unit")]
    public required string Unit { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
