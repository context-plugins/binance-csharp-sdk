using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1ConvertLimitCancelOrderResponse
{
    [JsonPropertyName("orderId")]
    public required long OrderId { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }
}
