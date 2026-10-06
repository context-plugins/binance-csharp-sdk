using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Row15
{
    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("_flexibleDailyInterestRate")]
    public required string FlexibleDailyInterestRate { get; init; }

    [JsonPropertyName("_flexibleYearlyInterestRate")]
    public required string FlexibleYearlyInterestRate { get; init; }

    [JsonPropertyName("_30dDailyInterestRate")]
    public required string DDailyInterestRate30 { get; init; }

    [JsonPropertyName("_30dYearlyInterestRate")]
    public required string DYearlyInterestRate30 { get; init; }

    [JsonPropertyName("_60dDailyInterestRate")]
    public required string DDailyInterestRate60 { get; init; }

    [JsonPropertyName("_60dYearlyInterestRate")]
    public required string DYearlyInterestRate60 { get; init; }

    [JsonPropertyName("minLimit")]
    public required string MinLimit { get; init; }

    [JsonPropertyName("maxLimit")]
    public required string MaxLimit { get; init; }

    [JsonPropertyName("vipLevel")]
    public required int VipLevel { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
