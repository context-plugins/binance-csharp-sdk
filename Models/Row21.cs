using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Row21
{
    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    [JsonPropertyName("direction")]
    public required string Direction { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("preLTV")]
    public required string PreLtv { get; init; }

    [JsonPropertyName("afterLTV")]
    public required string AfterLtv { get; init; }

    [JsonPropertyName("adjustTime")]
    public required long AdjustTime { get; init; }

    [JsonPropertyName("orderId")]
    public required long OrderId { get; init; }
}
