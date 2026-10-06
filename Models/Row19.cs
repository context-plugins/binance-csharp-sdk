using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Row19
{
    [JsonPropertyName("orderId")]
    public required long OrderId { get; init; }

    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("totalDebt")]
    public required string TotalDebt { get; init; }

    [JsonPropertyName("residualInterest")]
    public required string ResidualInterest { get; init; }

    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    [JsonPropertyName("collateralAmount")]
    public required string CollateralAmount { get; init; }

    [JsonPropertyName("currentLTV")]
    public required string CurrentLtv { get; init; }

    [JsonPropertyName("expirationTime")]
    public required long ExpirationTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
