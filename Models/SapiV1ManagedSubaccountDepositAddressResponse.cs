using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1ManagedSubaccountDepositAddressResponse
{
    [JsonPropertyName("coin")]
    public required string Coin { get; init; }

    [JsonPropertyName("address")]
    public required string Address { get; init; }

    [JsonPropertyName("tag")]
    public required string Tag { get; init; }

    [JsonPropertyName("url")]
    public required string Url { get; init; }
}
