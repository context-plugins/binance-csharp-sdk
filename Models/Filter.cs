using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Filter
{
    [JsonPropertyName("filterType")]
    public required string FilterType { get; init; }

    [JsonPropertyName("minPrice")]
    public required string MinPrice { get; init; }

    [JsonPropertyName("maxPrice")]
    public required string MaxPrice { get; init; }

    [JsonPropertyName("tickSize")]
    public required string TickSize { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
