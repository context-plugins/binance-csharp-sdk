using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record RoiAndDimensionTypeList
{
    [JsonPropertyName("simulateRoi")]
    public required string SimulateRoi { get; init; }

    [JsonPropertyName("dimensionValue")]
    public required string DimensionValue { get; init; }

    [JsonPropertyName("dimensionUnit")]
    public required string DimensionUnit { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
