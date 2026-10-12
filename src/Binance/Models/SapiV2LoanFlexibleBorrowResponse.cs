using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV2LoanFlexibleBorrowResponse
{
    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("loanAmount")]
    public required string LoanAmount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("collateralCoin")]
    public string? CollateralCoin { get; init; }

    [JsonPropertyName("collateralAmount")]
    public required string CollateralAmount { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
