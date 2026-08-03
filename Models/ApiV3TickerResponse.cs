using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record ApiV3TickerResponse
{
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("priceChange")]
    public required string PriceChange { get; init; }

    [JsonPropertyName("priceChangePercent")]
    public required string PriceChangePercent { get; init; }

    [JsonPropertyName("weightedAvgPrice")]
    public required string WeightedAvgPrice { get; init; }

    [JsonPropertyName("openPrice")]
    public required string OpenPrice { get; init; }

    [JsonPropertyName("highPrice")]
    public required string HighPrice { get; init; }

    [JsonPropertyName("lowPrice")]
    public required string LowPrice { get; init; }

    [JsonPropertyName("lastPrice")]
    public required string LastPrice { get; init; }

    [JsonPropertyName("volume")]
    public required string Volume { get; init; }

    [JsonPropertyName("quoteVolume")]
    public required string QuoteVolume { get; init; }

    [JsonPropertyName("openTime")]
    public required long OpenTime { get; init; }

    [JsonPropertyName("closeTime")]
    public required long CloseTime { get; init; }

    [JsonPropertyName("firstId")]
    public required long FirstId { get; init; }

    [JsonPropertyName("lastId")]
    public required long LastId { get; init; }

    [JsonPropertyName("count")]
    public required long Count { get; init; }
}
