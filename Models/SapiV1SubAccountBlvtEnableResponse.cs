using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SubAccountBlvtEnableResponse
{
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    [JsonPropertyName("enableBlvt")]
    public required bool EnableBlvt { get; init; }
}
