using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Row31
{
    [JsonPropertyName("time")]
    public required long Time { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// PENDING, SUCCESS, FAILED
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("distributeAmount")]
    public required string DistributeAmount { get; init; }

    [JsonPropertyName("conversionRatio")]
    public required string ConversionRatio { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
