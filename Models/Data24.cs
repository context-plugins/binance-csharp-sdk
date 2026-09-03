using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Data24
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    /// <summary>
    /// rebate type：1 is commission rebate，2 is referral kickback
    /// </summary>
    [JsonPropertyName("type")]
    public required int Type { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("updateTime")]
    public required long UpdateTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
