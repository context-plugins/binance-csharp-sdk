using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SubAccountFuturesEnableResponse
{
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    [JsonPropertyName("isFuturesEnabled")]
    public required bool IsFuturesEnabled { get; init; }
}
