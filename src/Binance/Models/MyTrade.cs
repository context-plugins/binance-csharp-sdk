using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record MyTrade
{
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    /// <summary>
    /// Trade id
    /// </summary>
    [JsonPropertyName("id")]
    public required long Id { get; init; }

    [JsonPropertyName("orderId")]
    public required long OrderId { get; init; }

    [JsonPropertyName("orderListId")]
    public required long OrderListId { get; init; }

    /// <summary>
    /// Price
    /// </summary>
    [JsonPropertyName("price")]
    public required string Price { get; init; }

    /// <summary>
    /// Amount of base asset
    /// </summary>
    [JsonPropertyName("qty")]
    public required string Qty { get; init; }

    /// <summary>
    /// Amount of quote asset
    /// </summary>
    [JsonPropertyName("quoteQty")]
    public required string QuoteQty { get; init; }

    [JsonPropertyName("commission")]
    public required string Commission { get; init; }

    [JsonPropertyName("commissionAsset")]
    public required string CommissionAsset { get; init; }

    /// <summary>
    /// Trade timestamp
    /// </summary>
    [JsonPropertyName("time")]
    public required long Time { get; init; }

    [JsonPropertyName("isBuyer")]
    public required bool IsBuyer { get; init; }

    [JsonPropertyName("isMaker")]
    public required bool IsMaker { get; init; }

    [JsonPropertyName("isBestMatch")]
    public required bool IsBestMatch { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
