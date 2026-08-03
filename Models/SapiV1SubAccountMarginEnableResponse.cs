using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SubAccountMarginEnableResponse
{
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    [JsonPropertyName("isMarginEnabled")]
    public required bool IsMarginEnabled { get; init; }
}
