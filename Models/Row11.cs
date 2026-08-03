using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Row11
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("tranId")]
    public required long TranId { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("timestamp")]
    public required long Timestamp { get; init; }

    /// <summary>
    /// one of PENDING (pending to execution), CONFIRMED (successfully transfered), FAILED (execution failed, nothing happened to your account);
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }
}
