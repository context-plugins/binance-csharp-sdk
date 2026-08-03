using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record TriggerCondition
{
    /// <summary>
    /// Number of GTC orders
    /// </summary>
    [JsonPropertyName("GCR")]
    public required long Gcr { get; init; }

    /// <summary>
    /// Number of FOK/IOC orders
    /// </summary>
    [JsonPropertyName("IFER")]
    public required long Ifer { get; init; }

    /// <summary>
    /// Number of orders
    /// </summary>
    [JsonPropertyName("UFR")]
    public required long Ufr { get; init; }
}
