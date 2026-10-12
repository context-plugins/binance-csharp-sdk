using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record CancelResponse
{
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("origClientOrderId")]
    public required string OrigClientOrderId { get; init; }

    [JsonPropertyName("orderId")]
    public required long OrderId { get; init; }

    [JsonPropertyName("orderListId")]
    public required long OrderListId { get; init; }

    [JsonPropertyName("clientOrderId")]
    public required string ClientOrderId { get; init; }

    [JsonPropertyName("price")]
    public required string Price { get; init; }

    [JsonPropertyName("origQty")]
    public required string OrigQty { get; init; }

    [JsonPropertyName("executedQty")]
    public required string ExecutedQty { get; init; }

    [JsonPropertyName("cummulativeQuoteQty")]
    public required string CummulativeQuoteQty { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("timeInForce")]
    public required string TimeInForce { get; init; }

    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("side")]
    public required string Side { get; init; }

    [JsonPropertyName("selfTradePreventionMode")]
    public required string SelfTradePreventionMode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactTime")]
    public long? TransactTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
