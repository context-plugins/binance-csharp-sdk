using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1PortfolioAutoCollectionResponse
{
    [JsonPropertyName("msg")]
    public required string Msg { get; init; }
}
