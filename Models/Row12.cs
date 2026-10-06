using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Row12
{
    [JsonPropertyName("orderId")]
    public required long OrderId { get; init; }

    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("totalDebt")]
    public required string TotalDebt { get; init; }

    [JsonPropertyName("residualInterest")]
    public required string ResidualInterest { get; init; }

    [JsonPropertyName("collateralAccountId")]
    public required string CollateralAccountId { get; init; }

    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    /// <summary>
    /// locked collateral value shown in USD value
    /// </summary>
    [JsonPropertyName("collateralValue")]
    public required string CollateralValue { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalCollateralValueAfterHaircut")]
    public string? TotalCollateralValueAfterHaircut { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lockedCollateralValue")]
    public string? LockedCollateralValue { get; init; }

    [JsonPropertyName("currentLTV")]
    public required string CurrentLtv { get; init; }

    [JsonPropertyName("expirationTime")]
    public required long ExpirationTime { get; init; }

    [JsonPropertyName("loanDate")]
    public required string LoanDate { get; init; }

    [JsonPropertyName("loanRate")]
    public required string LoanRate { get; init; }

    [JsonPropertyName("loanTerm")]
    public required string LoanTerm { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
