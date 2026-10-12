using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
