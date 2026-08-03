using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SimpleEarnLockedRedeemResponse
{
    [JsonPropertyName("redeemId")]
    public required long RedeemId { get; init; }

    [JsonPropertyName("success")]
    public required bool Success { get; init; }
}
