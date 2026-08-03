using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record CommissionRates
{
    [JsonPropertyName("maker")]
    public required string Maker { get; init; }

    [JsonPropertyName("taker")]
    public required string Taker { get; init; }

    [JsonPropertyName("buyer")]
    public required string Buyer { get; init; }

    [JsonPropertyName("seller")]
    public required string Seller { get; init; }
}
