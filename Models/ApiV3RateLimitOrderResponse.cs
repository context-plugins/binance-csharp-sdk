using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record ApiV3RateLimitOrderResponse
{
    [JsonPropertyName("rateLimitType")]
    public required string RateLimitType { get; init; }

    [JsonPropertyName("interval")]
    public required string Interval { get; init; }

    [JsonPropertyName("intervalNum")]
    public required int IntervalNum { get; init; }

    [JsonPropertyName("limit")]
    public required int Limit { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("count")]
    public int? Count { get; init; }
}
