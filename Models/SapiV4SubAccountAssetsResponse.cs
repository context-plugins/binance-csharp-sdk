using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV4SubAccountAssetsResponse
{
    [JsonPropertyName("balances")]
    public required IReadOnlyList<Balance> Balances { get; init; }
}
