using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

/// <summary>
/// Tax commission rates for trades from the order.
/// </summary>
public record TaxCommission
{
    [JsonPropertyName("maker")]
    public required string Maker { get; init; }

    [JsonPropertyName("taker")]
    public required string Taker { get; init; }

    [JsonPropertyName("buyer")]
    public required string Buyer { get; init; }

    [JsonPropertyName("seller")]
    public required string Seller { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
