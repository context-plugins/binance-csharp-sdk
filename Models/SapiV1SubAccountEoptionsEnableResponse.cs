using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SubAccountEoptionsEnableResponse
{
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    [JsonPropertyName("isEOptionsEnabled")]
    public required bool IsEoptionsEnabled { get; init; }
}
