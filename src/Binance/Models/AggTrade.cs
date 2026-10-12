using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record AggTrade
{
    /// <summary>
    /// Aggregate tradeId
    /// </summary>
    [JsonPropertyName("a")]
    public required long A { get; init; }

    /// <summary>
    /// Price
    /// </summary>
    [JsonPropertyName("p")]
    public required string P { get; init; }

    /// <summary>
    /// Quantity
    /// </summary>
    [JsonPropertyName("q")]
    public required string Q { get; init; }

    /// <summary>
    /// First tradeId
    /// </summary>
    [JsonPropertyName("f")]
    public required long F { get; init; }

    /// <summary>
    /// Last tradeId
    /// </summary>
    [JsonPropertyName("l")]
    public required long L { get; init; }

    /// <summary>
    /// Timestamp
    /// </summary>
    [JsonPropertyName("T")]
    public required bool T { get; init; }

    /// <summary>
    /// Was the buyer the maker?
    /// </summary>
    [JsonPropertyName("m")]
    public required bool M { get; init; }

    /// <summary>
    /// Was the trade the best price match?
    /// </summary>
    [JsonPropertyName("M")]
    public required bool M2 { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
