using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record TierAnnualPercentageRate
{
    [JsonPropertyName("0-5BTC")]
    public required double Btc05 { get; init; }

    [JsonPropertyName("5-10BTC")]
    public required double Btc510 { get; init; }
}
