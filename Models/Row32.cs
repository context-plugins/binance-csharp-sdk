using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Row32
{
    [JsonPropertyName("time")]
    public required long Time { get; init; }

    [JsonPropertyName("arrivalTime")]
    public required long ArrivalTime { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// PENDING, SUCCESS, FAILED
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("distributeAsset")]
    public required string DistributeAsset { get; init; }

    [JsonPropertyName("distributeAmount")]
    public required string DistributeAmount { get; init; }

    [JsonPropertyName("conversionRatio")]
    public required string ConversionRatio { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
