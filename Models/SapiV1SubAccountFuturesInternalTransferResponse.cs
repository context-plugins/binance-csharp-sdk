using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SubAccountFuturesInternalTransferResponse
{
    [JsonPropertyName("success")]
    public required bool Success { get; init; }

    [JsonPropertyName("futuresType")]
    public required int FuturesType { get; init; }

    [JsonPropertyName("transfers")]
    public required IReadOnlyList<Transfer> Transfers { get; init; }
}
