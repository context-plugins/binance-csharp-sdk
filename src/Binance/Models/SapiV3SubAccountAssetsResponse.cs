using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV3SubAccountAssetsResponse
{
    [JsonPropertyName("balances")]
    public required IReadOnlyList<Balance2> Balances { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
