using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SimpleEarnLockedSetRedeemOptionResponse
{
    [JsonPropertyName("success")]
    public required bool Success { get; init; }
}
