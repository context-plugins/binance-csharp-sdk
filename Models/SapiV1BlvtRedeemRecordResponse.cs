using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1BlvtRedeemRecordResponse
{
    [JsonPropertyName("id")]
    public required long Id { get; init; }

    [JsonPropertyName("tokenName")]
    public required string TokenName { get; init; }

    /// <summary>
    /// Redemption amount
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// NAV of redemption
    /// </summary>
    [JsonPropertyName("nav")]
    public required string Nav { get; init; }

    /// <summary>
    /// Reemption fee
    /// </summary>
    [JsonPropertyName("fee")]
    public required string Fee { get; init; }

    /// <summary>
    /// Net redemption value in usdt
    /// </summary>
    [JsonPropertyName("netProceed")]
    public required string NetProceed { get; init; }

    [JsonPropertyName("timestamp")]
    public required long Timestamp { get; init; }
}
