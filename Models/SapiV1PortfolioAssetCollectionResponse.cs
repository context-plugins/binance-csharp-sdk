using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1PortfolioAssetCollectionResponse
{
    [JsonPropertyName("msg")]
    public required string Msg { get; init; }
}
