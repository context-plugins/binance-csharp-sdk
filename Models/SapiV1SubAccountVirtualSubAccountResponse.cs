using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SubAccountVirtualSubAccountResponse
{
    [JsonPropertyName("email")]
    public required string Email { get; init; }
}
