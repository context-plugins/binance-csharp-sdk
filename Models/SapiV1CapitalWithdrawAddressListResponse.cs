using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1CapitalWithdrawAddressListResponse
{
    [JsonPropertyName("address")]
    public required string Address { get; init; }

    [JsonPropertyName("addressTag")]
    public required string AddressTag { get; init; }

    [JsonPropertyName("coin")]
    public required string Coin { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("network")]
    public required string Network { get; init; }

    [JsonPropertyName("origin")]
    public required string Origin { get; init; }

    [JsonPropertyName("originType")]
    public required string OriginType { get; init; }

    [JsonPropertyName("whiteStatus")]
    public required bool WhiteStatus { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
