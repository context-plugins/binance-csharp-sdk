using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Btcusdt
{
    /// <summary>
    /// Unfilled Ratio (UFR)
    /// </summary>
    [JsonPropertyName("i")]
    public required string I { get; init; }

    /// <summary>
    /// Count of all orders
    /// </summary>
    [JsonPropertyName("c")]
    public required long C { get; init; }

    /// <summary>
    /// Current UFR value
    /// </summary>
    [JsonPropertyName("v")]
    public required double V { get; init; }

    /// <summary>
    /// Trigger UFR value
    /// </summary>
    [JsonPropertyName("t")]
    public required double T { get; init; }
}
