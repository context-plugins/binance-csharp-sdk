using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Row25
{
    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("totalDebt")]
    public required string TotalDebt { get; init; }

    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    [JsonPropertyName("collateralAmount")]
    public required string CollateralAmount { get; init; }

    [JsonPropertyName("currentLTV")]
    public required string CurrentLtv { get; init; }
}
