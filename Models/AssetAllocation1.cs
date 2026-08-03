using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record AssetAllocation1
{
    /// <summary>
    /// for pie chart
    /// </summary>
    [JsonPropertyName("targetAsset")]
    public required string TargetAsset { get; init; }

    [JsonPropertyName("allocation")]
    public required string Allocation { get; init; }
}
