using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1SubAccountFuturesInternalTransferResponse1
{
    [JsonPropertyName("success")]
    public required bool Success { get; init; }

    [JsonPropertyName("txnId")]
    public required string TxnId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
