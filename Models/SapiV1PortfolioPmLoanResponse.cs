using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1PortfolioPmLoanResponse
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }
}
