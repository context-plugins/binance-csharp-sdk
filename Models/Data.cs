using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Data
{
    [JsonPropertyName("balances")]
    public required IReadOnlyList<Balance> Balances { get; init; }

    [JsonPropertyName("totalAssetOfBtc")]
    public required string TotalAssetOfBtc { get; init; }
}
