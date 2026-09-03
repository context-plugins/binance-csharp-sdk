using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record ProfitYesterday
{
    [JsonPropertyName("BTC")]
    public required string Btc { get; init; }

    [JsonPropertyName("BSV")]
    public required string Bsv { get; init; }

    [JsonPropertyName("BCH")]
    public required string Bch { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
