using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1LoanVipRepayResponse
{
    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("repayAmount")]
    public required string RepayAmount { get; init; }

    [JsonPropertyName("remainingPrincipal")]
    public required string RemainingPrincipal { get; init; }

    [JsonPropertyName("remainingInterest")]
    public required string RemainingInterest { get; init; }

    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    [JsonPropertyName("currentLTV")]
    public required string CurrentLtv { get; init; }

    /// <summary>
    /// Repaid, Repaying, Failed
    /// </summary>
    [JsonPropertyName("repayStatus")]
    public required string RepayStatus { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
