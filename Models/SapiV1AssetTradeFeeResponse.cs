using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1AssetTradeFeeResponse
{
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("makerCommission")]
    public required string MakerCommission { get; init; }

    [JsonPropertyName("takerCommission")]
    public required string TakerCommission { get; init; }
}
