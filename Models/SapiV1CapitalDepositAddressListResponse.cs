using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1CapitalDepositAddressListResponse
{
    [JsonPropertyName("coin")]
    public required string Coin { get; init; }

    [JsonPropertyName("address")]
    public required string Address { get; init; }

    [JsonPropertyName("isDefault")]
    public required int IsDefault { get; init; }
}
