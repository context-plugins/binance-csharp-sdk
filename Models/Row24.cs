using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Row24
{
    [JsonPropertyName("orderId")]
    public required string OrderId { get; init; }

    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    [JsonPropertyName("preMarginCall")]
    public required string PreMarginCall { get; init; }

    [JsonPropertyName("afterMarginCall")]
    public required string AfterMarginCall { get; init; }

    [JsonPropertyName("customizeTime")]
    public required long CustomizeTime { get; init; }
}
