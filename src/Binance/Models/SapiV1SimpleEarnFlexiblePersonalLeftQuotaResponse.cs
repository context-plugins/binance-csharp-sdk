using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse
{
    [JsonPropertyName("leftPersonalQuota")]
    public required string LeftPersonalQuota { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
