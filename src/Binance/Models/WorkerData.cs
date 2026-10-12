using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record WorkerData
{
    [JsonPropertyName("workerId")]
    public required string WorkerId { get; init; }

    [JsonPropertyName("workerName")]
    public required string WorkerName { get; init; }

    /// <summary>
    /// Status：1 valid, 2 invalid, 3 no longer valid
    /// </summary>
    [JsonPropertyName("status")]
    public required long Status { get; init; }

    /// <summary>
    /// Real-time rate
    /// </summary>
    [JsonPropertyName("hashRate")]
    public required long HashRate { get; init; }

    /// <summary>
    /// 24H Hashrate
    /// </summary>
    [JsonPropertyName("dayHashRate")]
    public required long DayHashRate { get; init; }

    /// <summary>
    /// Real-time Rejection Rate
    /// </summary>
    [JsonPropertyName("rejectRate")]
    public required long RejectRate { get; init; }

    /// <summary>
    /// Last submission time
    /// </summary>
    [JsonPropertyName("lastShareTime")]
    public required long LastShareTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
