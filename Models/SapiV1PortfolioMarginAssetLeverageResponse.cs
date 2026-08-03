using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1PortfolioMarginAssetLeverageResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("asset")]
    public string? Asset { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("collateralRate")]
    public string? CollateralRate { get; init; }
}
