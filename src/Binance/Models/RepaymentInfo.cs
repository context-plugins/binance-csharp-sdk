using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record RepaymentInfo
{
    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("remainingPrincipal")]
    public required string RemainingPrincipal { get; init; }

    [JsonPropertyName("remainingInterest")]
    public required string RemainingInterest { get; init; }

    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    [JsonPropertyName("remainingCollateral")]
    public required string RemainingCollateral { get; init; }

    [JsonPropertyName("currentLTV")]
    public required string CurrentLtv { get; init; }

    [JsonPropertyName("repayStatus")]
    public required string RepayStatus { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
