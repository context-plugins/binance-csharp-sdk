using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Row13
{
    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("repayAmount")]
    public required string RepayAmount { get; init; }

    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    /// <summary>
    /// Repaid, Repaying, Failed
    /// </summary>
    [JsonPropertyName("repayStatus")]
    public required string RepayStatus { get; init; }

    [JsonPropertyName("repayTime")]
    public required string RepayTime { get; init; }

    [JsonPropertyName("orderId")]
    public required string OrderId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
