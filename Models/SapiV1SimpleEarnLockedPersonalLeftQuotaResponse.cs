using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SimpleEarnLockedPersonalLeftQuotaResponse
{
    [JsonPropertyName("leftPersonalQuota")]
    public required string LeftPersonalQuota { get; init; }
}
