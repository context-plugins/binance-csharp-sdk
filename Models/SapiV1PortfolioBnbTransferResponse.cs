using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1PortfolioBnbTransferResponse
{
    [JsonPropertyName("tranId")]
    public required long TranId { get; init; }
}
