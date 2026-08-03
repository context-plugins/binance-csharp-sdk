using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

/// <summary>
/// The indicators updated every 30 seconds
/// </summary>
public record Indicators
{
    [JsonPropertyName("BTCUSDT")]
    public required IReadOnlyList<Btcusdt> Btcusdt { get; init; }
}
