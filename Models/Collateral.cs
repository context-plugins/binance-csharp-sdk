using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Collateral
{
    [JsonPropertyName("minUsdValue")]
    public required string MinUsdValue { get; init; }

    [JsonPropertyName("maxUsdValue")]
    public required string MaxUsdValue { get; init; }

    [JsonPropertyName("discountRate")]
    public required string DiscountRate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
