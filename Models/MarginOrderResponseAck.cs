using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

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
}
