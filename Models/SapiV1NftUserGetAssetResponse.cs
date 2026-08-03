using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1NftUserGetAssetResponse
{
    [JsonPropertyName("total")]
    public required int Total { get; init; }

    [JsonPropertyName("list")]
    public required IReadOnlyList<List6> List { get; init; }
}
