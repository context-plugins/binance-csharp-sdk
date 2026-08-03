using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV2LoanFlexibleRepayResponse
{
    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    [JsonPropertyName("remainingDebt")]
    public required string RemainingDebt { get; init; }

    [JsonPropertyName("remainingCollateral")]
    public required string RemainingCollateral { get; init; }

    [JsonPropertyName("fullRepayment")]
    public required bool FullRepayment { get; init; }

    [JsonPropertyName("currentLTV")]
    public required string CurrentLtv { get; init; }

    /// <summary>
    /// Repaid, Repaying, Failed
    /// </summary>
    [JsonPropertyName("repayStatus")]
    public required string RepayStatus { get; init; }
}
