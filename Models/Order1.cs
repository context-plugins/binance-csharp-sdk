using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Order1
{
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("orderId")]
    public required long OrderId { get; init; }

    [JsonPropertyName("clientOrderId")]
    public required string ClientOrderId { get; init; }
}
