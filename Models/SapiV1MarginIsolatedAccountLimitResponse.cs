using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1MarginIsolatedAccountLimitResponse
{
    [JsonPropertyName("enabledAccount")]
    public required long EnabledAccount { get; init; }

    [JsonPropertyName("maxAccount")]
    public required long MaxAccount { get; init; }
}
