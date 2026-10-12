using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Row18
{
    [JsonPropertyName("orderId")]
    public required long OrderId { get; init; }

    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("initialLoanAmount")]
    public required string InitialLoanAmount { get; init; }

    [JsonPropertyName("hourlyInterestRate")]
    public required string HourlyInterestRate { get; init; }

    [JsonPropertyName("loanTerm")]
    public required string LoanTerm { get; init; }

    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    [JsonPropertyName("initialCollateralAmount")]
    public required string InitialCollateralAmount { get; init; }

    [JsonPropertyName("borrowTime")]
    public required long BorrowTime { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
