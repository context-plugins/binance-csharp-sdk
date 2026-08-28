using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1SubAccountFuturesInternalTransferResponse1
{
    [JsonPropertyName("success")]
    public required bool Success { get; init; }

    [JsonPropertyName("txnId")]
    public required string TxnId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
