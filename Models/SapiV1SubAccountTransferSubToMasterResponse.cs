using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SubAccountTransferSubToMasterResponse
{
    [JsonPropertyName("txnId")]
    public required string TxnId { get; init; }
}
