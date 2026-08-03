using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1BlvtSubscribeRecordResponse
{
    [JsonPropertyName("id")]
    public required long Id { get; init; }

    [JsonPropertyName("tokenName")]
    public required string TokenName { get; init; }

    /// <summary>
    /// Subscription amount
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// NAV price of subscription
    /// </summary>
    [JsonPropertyName("nav")]
    public required string Nav { get; init; }

    /// <summary>
    /// Subscription fee in usdt
    /// </summary>
    [JsonPropertyName("fee")]
    public required string Fee { get; init; }

    /// <summary>
    /// Subscription cost in usdt
    /// </summary>
    [JsonPropertyName("totalCharge")]
    public required string TotalCharge { get; init; }

    [JsonPropertyName("timestamp")]
    public required long Timestamp { get; init; }
}
