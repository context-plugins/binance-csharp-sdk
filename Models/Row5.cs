using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Row5
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("targetAsset")]
    public required string TargetAsset { get; init; }

    [JsonPropertyName("targetAmount")]
    public required string TargetAmount { get; init; }

    [JsonPropertyName("bizType")]
    public required string BizType { get; init; }

    [JsonPropertyName("timestamp")]
    public required long Timestamp { get; init; }
}
