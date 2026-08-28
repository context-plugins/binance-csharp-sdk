using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1AssetAssetDetailResponse
{
    [JsonPropertyName("CTR")]
    public required Ctr Ctr { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
