using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1ConvertAcceptQuoteResponse
{
    [JsonPropertyName("orderId")]
    public required string OrderId { get; init; }

    [JsonPropertyName("createTime")]
    public required long CreateTime { get; init; }

    [JsonPropertyName("orderStatus")]
    public required string OrderStatus { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
