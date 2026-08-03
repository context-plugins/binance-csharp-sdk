using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1CapitalDepositSubAddressResponse
{
    [JsonPropertyName("address")]
    public required string Address { get; init; }

    [JsonPropertyName("coin")]
    public required string Coin { get; init; }

    [JsonPropertyName("tag")]
    public required string Tag { get; init; }

    [JsonPropertyName("url")]
    public required string Url { get; init; }
}
