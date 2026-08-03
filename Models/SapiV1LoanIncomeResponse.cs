using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1LoanIncomeResponse
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("timestamp")]
    public required long Timestamp { get; init; }

    [JsonPropertyName("tranId")]
    public required string TranId { get; init; }
}
