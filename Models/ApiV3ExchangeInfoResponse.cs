using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record ApiV3ExchangeInfoResponse
{
    [JsonPropertyName("timezone")]
    public required string Timezone { get; init; }

    [JsonPropertyName("serverTime")]
    public required long ServerTime { get; init; }

    [JsonPropertyName("rateLimits")]
    public required IReadOnlyList<RateLimit> RateLimits { get; init; }

    [JsonPropertyName("exchangeFilters")]
    public required IReadOnlyList<object> ExchangeFilters { get; init; }

    [JsonPropertyName("symbols")]
    public required IReadOnlyList<Symbol> Symbols { get; init; }
}
