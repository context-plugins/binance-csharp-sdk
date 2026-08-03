using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record RepaymentInfo2
{
    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    [JsonPropertyName("repayStatus")]
    public required string RepayStatus { get; init; }
}
