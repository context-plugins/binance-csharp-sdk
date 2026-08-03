using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1LoanAdjustLtvResponse
{
    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    [JsonPropertyName("direction")]
    public required string Direction { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("currentLTV")]
    public required string CurrentLtv { get; init; }
}
