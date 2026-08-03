using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record DayTicker
{
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    /// <summary>
    /// Absolute price change
    /// </summary>
    [JsonPropertyName("priceChange")]
    public required string PriceChange { get; init; }

    /// <summary>
    /// Relative price change in percent
    /// </summary>
    [JsonPropertyName("priceChangePercent")]
    public required string PriceChangePercent { get; init; }

    /// <summary>
    /// quoteVolume / volume
    /// </summary>
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

    /// <summary>
    /// Volume in base asset
    /// </summary>
    [JsonPropertyName("volume")]
    public required string Volume { get; init; }

    /// <summary>
    /// Volume in quote asset
    /// </summary>
    [JsonPropertyName("quoteVolume")]
    public required string QuoteVolume { get; init; }

    [JsonPropertyName("openTime")]
    public required long OpenTime { get; init; }

    [JsonPropertyName("closeTime")]
    public required long CloseTime { get; init; }

    /// <summary>
    /// Trade ID of the first trade in the interval
    /// </summary>
    [JsonPropertyName("firstId")]
    public required long FirstId { get; init; }

    /// <summary>
    /// Trade ID of the last trade in the interval
    /// </summary>
    [JsonPropertyName("lastId")]
    public required long LastId { get; init; }

    /// <summary>
    /// Number of trades in the interval
    /// </summary>
    [JsonPropertyName("count")]
    public required long Count { get; init; }
}
