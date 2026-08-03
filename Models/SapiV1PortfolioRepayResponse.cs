using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1PortfolioRepayResponse
{
    [JsonPropertyName("tranId")]
    public required long TranId { get; init; }
}
