using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SubAccountFuturesInternalTransferResponse1
{
    [JsonPropertyName("success")]
    public required bool Success { get; init; }

    [JsonPropertyName("txnId")]
    public required string TxnId { get; init; }
}
