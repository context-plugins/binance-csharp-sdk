using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1AssetDustResponse
{
    [JsonPropertyName("totalServiceCharge")]
    public required string TotalServiceCharge { get; init; }

    [JsonPropertyName("totalTransfered")]
    public required string TotalTransfered { get; init; }

    [JsonPropertyName("transferResult")]
    public required IReadOnlyList<TransferResult> TransferResult { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
