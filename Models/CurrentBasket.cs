using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record CurrentBasket
{
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("notionalValue")]
    public required string NotionalValue { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
