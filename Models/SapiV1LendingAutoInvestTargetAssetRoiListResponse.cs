using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1LendingAutoInvestTargetAssetRoiListResponse
{
    [JsonPropertyName("date")]
    public required string Date { get; init; }

    [JsonPropertyName("simulateRoi")]
    public required string SimulateRoi { get; init; }
}
