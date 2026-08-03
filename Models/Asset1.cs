using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Asset1
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("marginBalance")]
    public required string MarginBalance { get; init; }

    [JsonPropertyName("walletBalance")]
    public required string WalletBalance { get; init; }
}
