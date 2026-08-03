using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record MarginUserAssetVoList
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("borrowed")]
    public required string Borrowed { get; init; }

    [JsonPropertyName("free")]
    public required string Free { get; init; }

    [JsonPropertyName("interest")]
    public required string Interest { get; init; }

    [JsonPropertyName("locked")]
    public required string Locked { get; init; }

    [JsonPropertyName("netAsset")]
    public required string NetAsset { get; init; }
}
