using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record ApiV3AvgPriceResponse
{
    /// <summary>
    /// Average price interval (in minutes)
    /// </summary>
    [JsonPropertyName("mins")]
    public required long Mins { get; init; }

    /// <summary>
    /// Average price
    /// </summary>
    [JsonPropertyName("price")]
    public required string Price { get; init; }

    /// <summary>
    /// Last trade time
    /// </summary>
    [JsonPropertyName("closeTime")]
    public required long CloseTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
