using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1LoanVipRequestInterestRateResponse
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("flexibleDailyInterestRate")]
    public required string FlexibleDailyInterestRate { get; init; }

    [JsonPropertyName("flexibleYearlyInterestRate")]
    public required string FlexibleYearlyInterestRate { get; init; }

    [JsonPropertyName("time")]
    public required long Time { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
