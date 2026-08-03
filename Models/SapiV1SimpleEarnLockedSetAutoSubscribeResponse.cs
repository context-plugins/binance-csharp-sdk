using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SimpleEarnLockedSetAutoSubscribeResponse
{
    [JsonPropertyName("success")]
    public required bool Success { get; init; }
}
