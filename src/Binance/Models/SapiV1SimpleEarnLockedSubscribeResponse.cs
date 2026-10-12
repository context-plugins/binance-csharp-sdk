using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1SimpleEarnLockedSubscribeResponse
{
    [JsonPropertyName("purchaseId")]
    public required long PurchaseId { get; init; }

    [JsonPropertyName("positionId")]
    public required string PositionId { get; init; }

    [JsonPropertyName("success")]
    public required bool Success { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
