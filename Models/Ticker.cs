using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Ticker
{
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("priceChange")]
    public required string PriceChange { get; init; }

    [JsonPropertyName("priceChangePercent")]
    public required string PriceChangePercent { get; init; }

    [JsonPropertyName("prevClosePrice")]
    public required string PrevClosePrice { get; init; }

    [JsonPropertyName("lastPrice")]
    public required string LastPrice { get; init; }

    [JsonPropertyName("bidPrice")]
    public required string BidPrice { get; init; }

    [JsonPropertyName("bidQty")]
    public required string BidQty { get; init; }

    [JsonPropertyName("askPrice")]
    public required string AskPrice { get; init; }

    [JsonPropertyName("askQty")]
    public required string AskQty { get; init; }

    [JsonPropertyName("openPrice")]
    public required string OpenPrice { get; init; }

    [JsonPropertyName("highPrice")]
    public required string HighPrice { get; init; }

    [JsonPropertyName("lowPrice")]
    public required string LowPrice { get; init; }

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
