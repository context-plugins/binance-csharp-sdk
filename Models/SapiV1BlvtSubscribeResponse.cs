using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1BlvtSubscribeResponse
{
    [JsonPropertyName("id")]
    public required long Id { get; init; }

    /// <summary>
    /// S, P, and F for "success", "pending", and "failure"
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("tokenName")]
    public required string TokenName { get; init; }

    /// <summary>
    /// subscribed token amount
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// subscription cost in usdt
    /// </summary>
    [JsonPropertyName("cost")]
    public required string Cost { get; init; }

    [JsonPropertyName("timestamp")]
    public required long Timestamp { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
