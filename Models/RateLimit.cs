using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record RateLimit
{
    [JsonPropertyName("rateLimitType")]
    public required string RateLimitType { get; init; }

    [JsonPropertyName("interval")]
    public required string Interval { get; init; }

    [JsonPropertyName("intervalNum")]
    public required int IntervalNum { get; init; }

    [JsonPropertyName("limit")]
    public required int Limit { get; init; }
}
