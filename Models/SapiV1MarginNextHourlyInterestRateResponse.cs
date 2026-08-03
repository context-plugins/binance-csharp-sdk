using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1MarginNextHourlyInterestRateResponse
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("nextHourlyInterestRate")]
    public required string NextHourlyInterestRate { get; init; }
}
