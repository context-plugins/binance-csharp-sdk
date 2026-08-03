using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SimpleEarnFlexiblePersonalLeftQuotaResponse
{
    [JsonPropertyName("leftPersonalQuota")]
    public required string LeftPersonalQuota { get; init; }
}
