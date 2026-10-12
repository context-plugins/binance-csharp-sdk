using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1MarginIsolatedAllPairsResponse
{
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("base")]
    public required string Base { get; init; }

    [JsonPropertyName("quote")]
    public required string Quote { get; init; }

    [JsonPropertyName("isMarginTrade")]
    public required bool IsMarginTrade { get; init; }

    [JsonPropertyName("isBuyAllowed")]
    public required bool IsBuyAllowed { get; init; }

    [JsonPropertyName("isSellAllowed")]
    public required bool IsSellAllowed { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
