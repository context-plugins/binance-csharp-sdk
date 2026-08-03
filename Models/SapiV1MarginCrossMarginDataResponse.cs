using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1MarginCrossMarginDataResponse
{
    [JsonPropertyName("vipLevel")]
    public required int VipLevel { get; init; }

    [JsonPropertyName("coin")]
    public required string Coin { get; init; }

    [JsonPropertyName("transferIn")]
    public required bool TransferIn { get; init; }

    [JsonPropertyName("borrowable")]
    public required bool Borrowable { get; init; }

    [JsonPropertyName("dailyInterest")]
    public required string DailyInterest { get; init; }

    [JsonPropertyName("yearlyInterest")]
    public required string YearlyInterest { get; init; }

    [JsonPropertyName("borrowLimit")]
    public required string BorrowLimit { get; init; }

    [JsonPropertyName("marginablePairs")]
    public required IReadOnlyList<string> MarginablePairs { get; init; }
}
