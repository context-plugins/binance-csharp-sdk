using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1LoanVipBorrowResponse
{
    [JsonPropertyName("loanAccountId")]
    public required string LoanAccountId { get; init; }

    [JsonPropertyName("requestId")]
    public required string RequestId { get; init; }

    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("isFlexibleRate")]
    public required string IsFlexibleRate { get; init; }

    [JsonPropertyName("loanAmount")]
    public required string LoanAmount { get; init; }

    [JsonPropertyName("collateralAccountId")]
    public required string CollateralAccountId { get; init; }

    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loanTerm")]
    public string? LoanTerm { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
