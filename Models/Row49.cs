using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Row49
{
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("productId")]
    public required string ProductId { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("createTime")]
    public required long CreateTime { get; init; }

    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("productName")]
    public required string ProductName { get; init; }

    [JsonPropertyName("orderId")]
    public required long OrderId { get; init; }
}
