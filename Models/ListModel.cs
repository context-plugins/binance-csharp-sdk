using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record ListModel
{
    [JsonPropertyName("time")]
    public required long Time { get; init; }

    [JsonPropertyName("hashrate")]
    public required string Hashrate { get; init; }

    [JsonPropertyName("reject")]
    public required string Reject { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
