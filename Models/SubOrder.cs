using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SubOrder
{
    [JsonPropertyName("algoId")]
    public required long AlgoId { get; init; }

    [JsonPropertyName("orderId")]
    public required long OrderId { get; init; }

    [JsonPropertyName("orderStatus")]
    public required string OrderStatus { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("executedQty")]
    public string? ExecutedQty { get; init; }

    [JsonPropertyName("executedAmt")]
    public required string ExecutedAmt { get; init; }

    [JsonPropertyName("feeAmt")]
    public required string FeeAmt { get; init; }

    [JsonPropertyName("feeAsset")]
    public required string FeeAsset { get; init; }

    [JsonPropertyName("bookTime")]
    public required long BookTime { get; init; }

    [JsonPropertyName("avgPrice")]
    public required string AvgPrice { get; init; }

    [JsonPropertyName("side")]
    public required string Side { get; init; }

    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("subId")]
    public required long SubId { get; init; }

    [JsonPropertyName("timeInForce")]
    public required string TimeInForce { get; init; }

    [JsonPropertyName("origQty")]
    public required string OrigQty { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
