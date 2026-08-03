using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1PortfolioRepayFuturesNegativeBalanceResponse
{
    [JsonPropertyName("msg")]
    public required string Msg { get; init; }
}
