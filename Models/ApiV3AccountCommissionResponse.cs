using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record ApiV3AccountCommissionResponse
{
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    /// <summary>
    /// Standard commission rates on trades from the order.
    /// </summary>
    [JsonPropertyName("standardCommission")]
    public required StandardCommission StandardCommission { get; init; }

    /// <summary>
    /// Tax commission rates for trades from the order.
    /// </summary>
    [JsonPropertyName("taxCommission")]
    public required TaxCommission TaxCommission { get; init; }

    /// <summary>
    /// Discount commission when paying in BNB.
    /// </summary>
    [JsonPropertyName("discount")]
    public required Discount Discount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
