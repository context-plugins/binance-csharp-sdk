using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Trade
{
    /// <summary>
    /// trade id
    /// </summary>
    [JsonPropertyName("id")]
    public required long Id { get; init; }

    /// <summary>
    /// price
    /// </summary>
    [JsonPropertyName("price")]
    public required string Price { get; init; }

    /// <summary>
    /// amount of base asset
    /// </summary>
    [JsonPropertyName("qty")]
    public required string Qty { get; init; }

    /// <summary>
    /// amount of quote asset
    /// </summary>
    [JsonPropertyName("quoteQty")]
    public required string QuoteQty { get; init; }

    /// <summary>
    /// Trade executed timestamp, as same as <c>T</c> in the stream
    /// </summary>
    [JsonPropertyName("time")]
    public required long Time { get; init; }

    [JsonPropertyName("isBuyerMaker")]
    public required bool IsBuyerMaker { get; init; }

    [JsonPropertyName("isBestMatch")]
    public required bool IsBestMatch { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
