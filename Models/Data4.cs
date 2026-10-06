using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Data4
{
    /// <summary>
    /// API trading function is locked or not
    /// </summary>
    [JsonPropertyName("isLocked")]
    public required bool IsLocked { get; init; }

    /// <summary>
    /// If API trading function is locked, this is the planned recover time
    /// </summary>
    [JsonPropertyName("plannedRecoverTime")]
    public required long PlannedRecoverTime { get; init; }

    [JsonPropertyName("triggerCondition")]
    public required TriggerCondition TriggerCondition { get; init; }

    /// <summary>
    /// The indicators updated every 30 seconds
    /// </summary>
    [JsonPropertyName("indicators")]
    public required Indicators Indicators { get; init; }

    [JsonPropertyName("updateTime")]
    public required long UpdateTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
