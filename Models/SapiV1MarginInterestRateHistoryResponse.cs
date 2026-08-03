using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1MarginInterestRateHistoryResponse
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("dailyInterestRate")]
    public required string DailyInterestRate { get; init; }

    [JsonPropertyName("timestamp")]
    public required long Timestamp { get; init; }

    [JsonPropertyName("vipLevel")]
    public required int VipLevel { get; init; }
}
