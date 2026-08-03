using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record CollateralInfo
{
    [JsonPropertyName("tierFloor")]
    public required string TierFloor { get; init; }

    [JsonPropertyName("tierCap")]
    public required string TierCap { get; init; }

    [JsonPropertyName("collateralRate")]
    public required string CollateralRate { get; init; }
}
