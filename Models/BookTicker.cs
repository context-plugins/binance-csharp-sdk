using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record BookTicker
{
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("bidPrice")]
    public required string BidPrice { get; init; }

    [JsonPropertyName("bidQty")]
    public required string BidQty { get; init; }

    [JsonPropertyName("askPrice")]
    public required string AskPrice { get; init; }

    [JsonPropertyName("askQty")]
    public required string AskQty { get; init; }
}
