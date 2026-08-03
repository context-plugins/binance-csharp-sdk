using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1AssetTransferResponse1
{
    [JsonPropertyName("tranId")]
    public required long TranId { get; init; }
}
