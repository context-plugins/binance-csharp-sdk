using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Row17
{
    [JsonPropertyName("loanAccountId")]
    public required string LoanAccountId { get; init; }

    [JsonPropertyName("orderId")]
    public required string OrderId { get; init; }

    [JsonPropertyName("requestId")]
    public required string RequestId { get; init; }

    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("loanAmount")]
    public required string LoanAmount { get; init; }

    [JsonPropertyName("collateralAccountId")]
    public required string CollateralAccountId { get; init; }

    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    [JsonPropertyName("loanTerm")]
    public required int LoanTerm { get; init; }

    [JsonPropertyName("status")]
    public required int Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
