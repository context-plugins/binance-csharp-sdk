using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1ConvertExchangeInfoResponse
{
    [JsonPropertyName("fromAsset")]
    public required string FromAsset { get; init; }

    [JsonPropertyName("toAsset")]
    public required string ToAsset { get; init; }

    [JsonPropertyName("fromAssetMinAmount")]
    public required string FromAssetMinAmount { get; init; }

    [JsonPropertyName("fromAssetMaxAmount")]
    public required string FromAssetMaxAmount { get; init; }

    [JsonPropertyName("toAssetMinAmount")]
    public required string ToAssetMinAmount { get; init; }

    [JsonPropertyName("toAssetMaxAmount")]
    public required string ToAssetMaxAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
