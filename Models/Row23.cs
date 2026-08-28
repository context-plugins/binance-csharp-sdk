using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Row23
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

    [JsonPropertyName("vipLevel")]
    public required int VipLevel { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
