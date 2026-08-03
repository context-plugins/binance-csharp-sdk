using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1ConvertAssetInfoResponse
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("fraction")]
    public required int Fraction { get; init; }
}
