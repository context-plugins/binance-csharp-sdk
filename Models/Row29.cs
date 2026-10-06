using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Row29
{
    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("flexibleInterestRate")]
    public required string FlexibleInterestRate { get; init; }

    [JsonPropertyName("flexibleMinLimit")]
    public required string FlexibleMinLimit { get; init; }

    [JsonPropertyName("flexibleMaxLimit")]
    public required string FlexibleMaxLimit { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
