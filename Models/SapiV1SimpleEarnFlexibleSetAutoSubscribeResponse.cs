using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SimpleEarnFlexibleSetAutoSubscribeResponse
{
    [JsonPropertyName("success")]
    public required bool Success { get; init; }
}
