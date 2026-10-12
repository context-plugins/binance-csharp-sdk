using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record MarginOrderResponseAck
{
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("orderId")]
    public required long OrderId { get; init; }

    [JsonPropertyName("clientOrderId")]
    public required string ClientOrderId { get; init; }

    [JsonPropertyName("isIsolated")]
    public required bool IsIsolated { get; init; }

    [JsonPropertyName("transactTime")]
    public required long TransactTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
