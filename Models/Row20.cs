using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Row20
{
    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("repayAmount")]
    public required string RepayAmount { get; init; }

    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    [JsonPropertyName("collateralUsed")]
    public required string CollateralUsed { get; init; }

    [JsonPropertyName("collateralReturn")]
    public required string CollateralReturn { get; init; }

    [JsonPropertyName("repayType")]
    public required string RepayType { get; init; }

    /// <summary>
    /// 'repayType': '1' // 1 for 'repay with borrowed coin', 2 for 'repay with collateral' 'repayStatus': 'Repaid' // Repaid, Repaying, Failed
    /// </summary>
    [JsonPropertyName("repayStatus")]
    public required string RepayStatus { get; init; }

    [JsonPropertyName("repayTime")]
    public required long RepayTime { get; init; }

    [JsonPropertyName("orderId")]
    public required long OrderId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
