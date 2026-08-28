using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record HashrateData
{
    [JsonPropertyName("time")]
    public required long Time { get; init; }

    [JsonPropertyName("hashrate")]
    public required string Hashrate { get; init; }

    /// <summary>
    /// Rejection Rate
    /// </summary>
    [JsonPropertyName("reject")]
    public required long Reject { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
