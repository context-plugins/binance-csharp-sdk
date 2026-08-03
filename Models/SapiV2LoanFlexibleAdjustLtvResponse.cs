using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV2LoanFlexibleAdjustLtvResponse
{
    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    [JsonPropertyName("direction")]
    public required string Direction { get; init; }

    [JsonPropertyName("adjustmentAmount")]
    public required string AdjustmentAmount { get; init; }

    [JsonPropertyName("currentLTV")]
    public required string CurrentLtv { get; init; }
}
