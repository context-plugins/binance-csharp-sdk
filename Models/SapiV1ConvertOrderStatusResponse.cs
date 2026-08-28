using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1ConvertOrderStatusResponse
{
    [JsonPropertyName("orderId")]
    public required long OrderId { get; init; }

    [JsonPropertyName("orderStatus")]
    public required string OrderStatus { get; init; }

    [JsonPropertyName("fromAsset")]
    public required string FromAsset { get; init; }

    [JsonPropertyName("fromAmount")]
    public required string FromAmount { get; init; }

    [JsonPropertyName("toAsset")]
    public required string ToAsset { get; init; }

    [JsonPropertyName("toAmount")]
    public required string ToAmount { get; init; }

    [JsonPropertyName("ratio")]
    public required string Ratio { get; init; }

    [JsonPropertyName("inverseRatio")]
    public required string InverseRatio { get; init; }

    [JsonPropertyName("createTime")]
    public required long CreateTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
