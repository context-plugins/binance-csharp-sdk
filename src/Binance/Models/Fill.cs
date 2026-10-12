using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Fill
{
    [JsonPropertyName("price")]
    public required string Price { get; init; }

    [JsonPropertyName("qty")]
    public required string Qty { get; init; }

    [JsonPropertyName("commission")]
    public required string Commission { get; init; }

    [JsonPropertyName("commissionAsset")]
    public required string CommissionAsset { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
