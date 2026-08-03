using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1LendingPositionChangedResponse
{
    [JsonPropertyName("dailyPurchaseId")]
    public required long DailyPurchaseId { get; init; }

    [JsonPropertyName("success")]
    public required bool Success { get; init; }

    [JsonPropertyName("time")]
    public required long Time { get; init; }
}
