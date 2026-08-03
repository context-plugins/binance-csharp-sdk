using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1MarginAllPairsResponse
{
    [JsonPropertyName("base")]
    public required string Base { get; init; }

    [JsonPropertyName("id")]
    public required long Id { get; init; }

    [JsonPropertyName("isBuyAllowed")]
    public required bool IsBuyAllowed { get; init; }

    [JsonPropertyName("isMarginTrade")]
    public required bool IsMarginTrade { get; init; }

    [JsonPropertyName("isSellAllowed")]
    public required bool IsSellAllowed { get; init; }

    [JsonPropertyName("quote")]
    public required string Quote { get; init; }

    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }
}
