using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Profit
{
    [JsonPropertyName("amountFromWBETH")]
    public required string AmountFromWbeth { get; init; }

    [JsonPropertyName("amountFromBETH")]
    public required string AmountFromBeth { get; init; }
}
