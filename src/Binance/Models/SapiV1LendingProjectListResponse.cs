using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1LendingProjectListResponse
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("displayPriority")]
    public required long DisplayPriority { get; init; }

    [JsonPropertyName("duration")]
    public required long Duration { get; init; }

    [JsonPropertyName("interestPerLot")]
    public required string InterestPerLot { get; init; }

    [JsonPropertyName("interestRate")]
    public required string InterestRate { get; init; }

    [JsonPropertyName("lotSize")]
    public required string LotSize { get; init; }

    [JsonPropertyName("lotsLowLimit")]
    public required long LotsLowLimit { get; init; }

    [JsonPropertyName("lotsPurchased")]
    public required long LotsPurchased { get; init; }

    [JsonPropertyName("lotsUpLimit")]
    public required long LotsUpLimit { get; init; }

    [JsonPropertyName("maxLotsPerUser")]
    public required long MaxLotsPerUser { get; init; }

    [JsonPropertyName("needKyc")]
    public required bool NeedKyc { get; init; }

    [JsonPropertyName("projectId")]
    public required string ProjectId { get; init; }

    [JsonPropertyName("projectName")]
    public required string ProjectName { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("withAreaLimitation")]
    public required bool WithAreaLimitation { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
