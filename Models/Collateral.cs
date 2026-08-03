using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Collateral
{
    [JsonPropertyName("minUsdValue")]
    public required string MinUsdValue { get; init; }

    [JsonPropertyName("maxUsdValue")]
    public required string MaxUsdValue { get; init; }

    [JsonPropertyName("discountRate")]
    public required string DiscountRate { get; init; }
}
