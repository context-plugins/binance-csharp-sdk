using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

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
}
