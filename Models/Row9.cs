using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Row9
{
    [JsonPropertyName("createTime")]
    public required long CreateTime { get; init; }

    [JsonPropertyName("tranId")]
    public required long TranId { get; init; }

    [JsonPropertyName("type")]
    public required long Type { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
