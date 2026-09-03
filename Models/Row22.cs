using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Row22
{
    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("_7dHourlyInterestRate")]
    public required string DHourlyInterestRate7 { get; init; }

    [JsonPropertyName("_7dDailyInterestRate")]
    public required string DDailyInterestRate7 { get; init; }

    [JsonPropertyName("_14dHourlyInterestRate")]
    public required string DHourlyInterestRate14 { get; init; }

    [JsonPropertyName("_14dDailyInterestRate")]
    public required string DDailyInterestRate14 { get; init; }

    [JsonPropertyName("_30dHourlyInterestRate")]
    public required string DHourlyInterestRate30 { get; init; }

    [JsonPropertyName("_30dDailyInterestRate")]
    public required string DDailyInterestRate30 { get; init; }

    [JsonPropertyName("_90dHourlyInterestRate")]
    public required string DHourlyInterestRate90 { get; init; }

    [JsonPropertyName("_90dDailyInterestRate")]
    public required string DDailyInterestRate90 { get; init; }

    [JsonPropertyName("_180dHourlyInterestRate")]
    public required string DHourlyInterestRate180 { get; init; }

    [JsonPropertyName("_180dDailyInterestRate")]
    public required string DDailyInterestRate180 { get; init; }

    [JsonPropertyName("minLimit")]
    public required string MinLimit { get; init; }

    [JsonPropertyName("maxLimit")]
    public required string MaxLimit { get; init; }

    [JsonPropertyName("vipLevel")]
    public required int VipLevel { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
