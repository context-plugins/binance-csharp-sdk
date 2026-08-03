using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Row48
{
    [JsonPropertyName("productId")]
    public required string ProductId { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("annualPercentageRate")]
    public required string AnnualPercentageRate { get; init; }

    [JsonPropertyName("time")]
    public required long Time { get; init; }
}
