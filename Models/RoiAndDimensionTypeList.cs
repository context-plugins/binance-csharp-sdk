using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record RoiAndDimensionTypeList
{
    [JsonPropertyName("simulateRoi")]
    public required string SimulateRoi { get; init; }

    [JsonPropertyName("dimensionValue")]
    public required string DimensionValue { get; init; }

    [JsonPropertyName("dimensionUnit")]
    public required string DimensionUnit { get; init; }
}
