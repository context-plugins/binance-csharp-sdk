using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Assets2
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("marginBalance")]
    public required double MarginBalance { get; init; }

    [JsonPropertyName("walletBalance")]
    public required double WalletBalance { get; init; }
}
