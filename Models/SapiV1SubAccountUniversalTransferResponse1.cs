using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SubAccountUniversalTransferResponse1
{
    [JsonPropertyName("tranId")]
    public required long TranId { get; init; }

    [JsonPropertyName("clientTranId")]
    public required string ClientTranId { get; init; }
}
