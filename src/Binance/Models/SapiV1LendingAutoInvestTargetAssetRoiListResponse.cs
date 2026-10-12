using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1LendingAutoInvestTargetAssetRoiListResponse
{
    [JsonPropertyName("date")]
    public required string Date { get; init; }

    [JsonPropertyName("simulateRoi")]
    public required string SimulateRoi { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
