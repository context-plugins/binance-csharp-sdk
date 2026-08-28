using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1MarginIsolatedAccountLimitResponse
{
    [JsonPropertyName("enabledAccount")]
    public required long EnabledAccount { get; init; }

    [JsonPropertyName("maxAccount")]
    public required long MaxAccount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
