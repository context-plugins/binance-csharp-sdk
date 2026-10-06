using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record ApiV3OrderCancelReplaceResponse
{
    [JsonPropertyName("cancelResult")]
    public required string CancelResult { get; init; }

    [JsonPropertyName("newOrderResult")]
    public required string NewOrderResult { get; init; }

    [JsonPropertyName("cancelResponse")]
    public required CancelResponse CancelResponse { get; init; }

    [JsonPropertyName("newOrderResponse")]
    public required NewOrderResponse NewOrderResponse { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
