using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1MarginAllAssetsResponse
{
    [JsonPropertyName("assetFullName")]
    public required string AssetFullName { get; init; }

    [JsonPropertyName("assetName")]
    public required string AssetName { get; init; }

    [JsonPropertyName("isBorrowable")]
    public required bool IsBorrowable { get; init; }

    [JsonPropertyName("isMortgageable")]
    public required bool IsMortgageable { get; init; }

    [JsonPropertyName("userMinBorrow")]
    public required string UserMinBorrow { get; init; }

    [JsonPropertyName("userMinRepay")]
    public required string UserMinRepay { get; init; }
}
