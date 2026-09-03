using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record ExchangeRates
{
    [JsonPropertyName("USDC")]
    public required string Usdc { get; init; }

    [JsonPropertyName("TUSD")]
    public required string Tusd { get; init; }

    [JsonPropertyName("USDP")]
    public required string Usdp { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
