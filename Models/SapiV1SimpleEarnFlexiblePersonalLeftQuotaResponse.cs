using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse
{
    [JsonPropertyName("leftPersonalQuota")]
    public required string LeftPersonalQuota { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
