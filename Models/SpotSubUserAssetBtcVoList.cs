using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SpotSubUserAssetBtcVoList
{
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    [JsonPropertyName("totalAsset")]
    public required string TotalAsset { get; init; }
}
