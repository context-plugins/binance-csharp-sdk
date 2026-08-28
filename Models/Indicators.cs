using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

/// <summary>
/// The indicators updated every 30 seconds
/// </summary>
public record Indicators
{
    [JsonPropertyName("BTCUSDT")]
    public required IReadOnlyList<Btcusdt> Btcusdt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
