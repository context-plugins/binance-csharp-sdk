using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1MarginRateLimitOrderResponse
{
    [JsonPropertyName("rateLimitType")]
    public required string RateLimitType { get; init; }

    [JsonPropertyName("interval")]
    public required string Interval { get; init; }

    [JsonPropertyName("intervalNum")]
    public required long IntervalNum { get; init; }

    [JsonPropertyName("limit")]
    public required long Limit { get; init; }

    [JsonPropertyName("count")]
    public required long Count { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
