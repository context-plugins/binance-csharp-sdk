using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record PayerInfo
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("binanceId")]
    public required string BinanceId { get; init; }

    [JsonPropertyName("accountId")]
    public required string AccountId { get; init; }
}
