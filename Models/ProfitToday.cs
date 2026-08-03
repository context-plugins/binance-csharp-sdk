using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record ProfitToday
{
    [JsonPropertyName("BTC")]
    public required string Btc { get; init; }

    [JsonPropertyName("BSV")]
    public required string Bsv { get; init; }

    [JsonPropertyName("BCH")]
    public required string Bch { get; init; }
}
