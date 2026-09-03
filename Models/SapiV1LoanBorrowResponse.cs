using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1LoanBorrowResponse
{
    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("loanAmount")]
    public required string LoanAmount { get; init; }

    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    [JsonPropertyName("collateralAmount")]
    public required string CollateralAmount { get; init; }

    [JsonPropertyName("hourlyInterestRate")]
    public required string HourlyInterestRate { get; init; }

    [JsonPropertyName("orderId")]
    public required string OrderId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
