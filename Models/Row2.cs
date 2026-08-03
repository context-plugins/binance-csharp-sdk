using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Row2
{
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("timestamp")]
    public required long Timestamp { get; init; }

    [JsonPropertyName("txId")]
    public required long TxId { get; init; }

    [JsonPropertyName("type")]
    public required string Type { get; init; }
}
