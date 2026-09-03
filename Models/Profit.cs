using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Profit
{
    [JsonPropertyName("amountFromWBETH")]
    public required string AmountFromWbeth { get; init; }

    [JsonPropertyName("amountFromBETH")]
    public required string AmountFromBeth { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
