using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1SubAccountSubAccountApiIpRestrictionResponse
{
    [JsonPropertyName("ipRestrict")]
    public required string IpRestrict { get; init; }

    [JsonPropertyName("ipList")]
    public required IReadOnlyList<string> IpList { get; init; }

    [JsonPropertyName("updateTime")]
    public required long UpdateTime { get; init; }

    [JsonPropertyName("apiKey")]
    public required string ApiKey { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
