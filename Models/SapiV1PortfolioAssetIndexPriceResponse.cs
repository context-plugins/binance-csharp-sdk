using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1PortfolioAssetIndexPriceResponse
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("assetIndexPrice")]
    public required string AssetIndexPrice { get; init; }

    [JsonPropertyName("time")]
    public required long Time { get; init; }
}
