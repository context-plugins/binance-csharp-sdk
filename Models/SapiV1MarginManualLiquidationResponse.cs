using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1MarginManualLiquidationResponse
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("interest")]
    public required string Interest { get; init; }

    [JsonPropertyName("principal")]
    public required string Principal { get; init; }

    [JsonPropertyName("liabilityAsset")]
    public required string LiabilityAsset { get; init; }

    [JsonPropertyName("liabilityQty")]
    public required double LiabilityQty { get; init; }
}
