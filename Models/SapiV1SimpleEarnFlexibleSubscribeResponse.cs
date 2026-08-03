using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SimpleEarnFlexibleSubscribeResponse
{
    [JsonPropertyName("purchaseId")]
    public required long PurchaseId { get; init; }

    [JsonPropertyName("success")]
    public required bool Success { get; init; }
}
