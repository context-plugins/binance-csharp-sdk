using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1MarginIsolatedAccountResponse
{
    [JsonPropertyName("success")]
    public required bool Success { get; init; }

    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }
}
