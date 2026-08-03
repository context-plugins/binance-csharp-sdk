using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Data10
{
    [JsonPropertyName("coinName")]
    public required string CoinName { get; init; }

    [JsonPropertyName("coinId")]
    public required long CoinId { get; init; }

    [JsonPropertyName("poolIndex")]
    public required long PoolIndex { get; init; }

    [JsonPropertyName("algoId")]
    public required long AlgoId { get; init; }

    [JsonPropertyName("algoName")]
    public required string AlgoName { get; init; }
}
