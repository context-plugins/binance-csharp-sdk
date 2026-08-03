using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV3SubAccountAssetsResponse
{
    [JsonPropertyName("balances")]
    public required IReadOnlyList<Balance2> Balances { get; init; }
}
