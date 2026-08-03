using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record BnbBurnStatus
{
    [JsonPropertyName("spotBNBBurn")]
    public required bool SpotBnbburn { get; init; }

    [JsonPropertyName("interestBNBBurn")]
    public required bool InterestBnbburn { get; init; }
}
