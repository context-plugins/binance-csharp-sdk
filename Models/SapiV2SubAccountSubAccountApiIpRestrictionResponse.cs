using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV2SubAccountSubAccountApiIpRestrictionResponse
{
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("ipList")]
    public required IReadOnlyList<string> IpList { get; init; }

    [JsonPropertyName("updateTime")]
    public required long UpdateTime { get; init; }

    [JsonPropertyName("apiKey")]
    public required string ApiKey { get; init; }
}
