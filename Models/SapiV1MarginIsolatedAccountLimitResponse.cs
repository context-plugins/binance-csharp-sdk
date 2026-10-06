using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1MarginIsolatedAccountLimitResponse
{
    [JsonPropertyName("enabledAccount")]
    public required long EnabledAccount { get; init; }

    [JsonPropertyName("maxAccount")]
    public required long MaxAccount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
