using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record List2
{
    [JsonPropertyName("quoteId")]
    public required string QuoteId { get; init; }

    [JsonPropertyName("orderId")]
    public required long OrderId { get; init; }

    [JsonPropertyName("orderStatus")]
    public required string OrderStatus { get; init; }

    [JsonPropertyName("fromAsset")]
    public required string FromAsset { get; init; }

    [JsonPropertyName("fromAmount")]
    public required string FromAmount { get; init; }

    [JsonPropertyName("toAsset")]
    public required string ToAsset { get; init; }

    [JsonPropertyName("toAmount")]
    public required string ToAmount { get; init; }

    /// <summary>
    /// price ratio
    /// </summary>
    [JsonPropertyName("ratio")]
    public required string Ratio { get; init; }

    /// <summary>
    /// inverse price
    /// </summary>
    [JsonPropertyName("inverseRatio")]
    public required string InverseRatio { get; init; }

    [JsonPropertyName("createTime")]
    public required long CreateTime { get; init; }
}
