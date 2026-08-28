using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Data11
{
    /// <summary>
    /// Mining Account name
    /// </summary>
    [JsonPropertyName("workerName")]
    public required string WorkerName { get; init; }

    /// <summary>
    /// Type of hourly hashrate
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("hashrateDatas")]
    public required IReadOnlyList<HashrateData> HashrateDatas { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
