using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SimpleEarnAccountResponse
{
    [JsonPropertyName("totalAmountInBTC")]
    public required string TotalAmountInBtc { get; init; }

    [JsonPropertyName("totalAmountInUSDT")]
    public required string TotalAmountInUsdt { get; init; }

    [JsonPropertyName("totalFlexibleAmountInBTC")]
    public required string TotalFlexibleAmountInBtc { get; init; }

    [JsonPropertyName("totalFlexibleAmountInUSDT")]
    public required string TotalFlexibleAmountInUsdt { get; init; }

    [JsonPropertyName("totalLockedInBTC")]
    public required string TotalLockedInBtc { get; init; }

    [JsonPropertyName("totalLockedInUSDT")]
    public required string TotalLockedInUsdt { get; init; }
}
