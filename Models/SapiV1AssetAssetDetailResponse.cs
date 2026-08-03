using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1AssetAssetDetailResponse
{
    [JsonPropertyName("CTR")]
    public required Ctr Ctr { get; init; }
}
