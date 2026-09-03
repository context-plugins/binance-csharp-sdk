using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Row14
{
    [JsonPropertyName("collateralAccountId")]
    public required string CollateralAccountId { get; init; }

    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    /// <summary>
    /// locked collateral value shown in USD value
    /// </summary>
    [JsonPropertyName("collateralValue")]
    public required string CollateralValue { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
