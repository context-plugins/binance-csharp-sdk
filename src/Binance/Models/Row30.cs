using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Row30
{
    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    [JsonPropertyName("initialLTV")]
    public required string InitialLtv { get; init; }

    [JsonPropertyName("marginCallLTV")]
    public required string MarginCallLtv { get; init; }

    [JsonPropertyName("liquidationLTV")]
    public required string LiquidationLtv { get; init; }

    [JsonPropertyName("maxLimit")]
    public required string MaxLimit { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
