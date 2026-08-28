using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Row27
{
    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("repayAmount")]
    public required string RepayAmount { get; init; }

    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    [JsonPropertyName("collateralReturn")]
    public required string CollateralReturn { get; init; }

    [JsonPropertyName("repayStatus")]
    public required string RepayStatus { get; init; }

    [JsonPropertyName("repayTime")]
    public required long RepayTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
