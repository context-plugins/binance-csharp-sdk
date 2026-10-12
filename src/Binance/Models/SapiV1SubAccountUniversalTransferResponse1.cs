using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1SubAccountUniversalTransferResponse1
{
    [JsonPropertyName("tranId")]
    public required long TranId { get; init; }

    [JsonPropertyName("clientTranId")]
    public required string ClientTranId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
