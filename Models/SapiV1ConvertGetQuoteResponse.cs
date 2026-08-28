using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1ConvertGetQuoteResponse
{
    [JsonPropertyName("quoteId")]
    public required string QuoteId { get; init; }

    [JsonPropertyName("ratio")]
    public required string Ratio { get; init; }

    [JsonPropertyName("inverseRatio")]
    public required string InverseRatio { get; init; }

    [JsonPropertyName("validTimestamp")]
    public required long ValidTimestamp { get; init; }

    [JsonPropertyName("toAmount")]
    public required string ToAmount { get; init; }

    [JsonPropertyName("fromAmount")]
    public required string FromAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
