using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1LoanVipRenewResponse
{
    [JsonPropertyName("loanAccountId")]
    public required string LoanAccountId { get; init; }

    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("loanAmount")]
    public required string LoanAmount { get; init; }

    [JsonPropertyName("collateralAccountId")]
    public required string CollateralAccountId { get; init; }

    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    [JsonPropertyName("loanTerm")]
    public required string LoanTerm { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
