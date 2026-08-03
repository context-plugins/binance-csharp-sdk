using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record OrderResponseAck
{
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("orderId")]
    public required long OrderId { get; init; }

    [JsonPropertyName("orderListId")]
    public required long OrderListId { get; init; }

    [JsonPropertyName("clientOrderId")]
    public required string ClientOrderId { get; init; }

    [JsonPropertyName("transactTime")]
    public required long TransactTime { get; init; }
}
