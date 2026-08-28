using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record CollateralInfo
{
    [JsonPropertyName("tierFloor")]
    public required string TierFloor { get; init; }

    [JsonPropertyName("tierCap")]
    public required string TierCap { get; init; }

    [JsonPropertyName("collateralRate")]
    public required string CollateralRate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
