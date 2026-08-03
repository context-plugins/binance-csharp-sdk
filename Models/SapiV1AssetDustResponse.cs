using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1AssetDustResponse
{
    [JsonPropertyName("totalServiceCharge")]
    public required string TotalServiceCharge { get; init; }

    [JsonPropertyName("totalTransfered")]
    public required string TotalTransfered { get; init; }

    [JsonPropertyName("transferResult")]
    public required IReadOnlyList<TransferResult> TransferResult { get; init; }
}
