using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1AssetConvertTransferResponse
{
    [JsonPropertyName("tranId")]
    public required long TranId { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }
}
