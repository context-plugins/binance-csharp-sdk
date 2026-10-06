using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

/// <summary>
/// Standard commission rates on trades from the order.
/// </summary>
public record StandardCommission
{
    [JsonPropertyName("maker")]
    public required string Maker { get; init; }

    [JsonPropertyName("taker")]
    public required string Taker { get; init; }

    [JsonPropertyName("buyer")]
    public required string Buyer { get; init; }

    [JsonPropertyName("seller")]
    public required string Seller { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
