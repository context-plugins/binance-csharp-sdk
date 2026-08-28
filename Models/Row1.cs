using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Row1
{
    /// <summary>
    /// Isolated symbol, will not be returned for crossed margin
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isolatedSymbol")]
    public string? IsolatedSymbol { get; init; }

    /// <summary>
    /// Total amount borrowed/repaid
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public string? Amount { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    /// <summary>
    /// Interest repaid
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interest")]
    public string? Interest { get; init; }

    /// <summary>
    /// Principal repaid
    /// </summary>
    [JsonPropertyName("principal")]
    public required string Principal { get; init; }

    /// <summary>
    /// one of PENDING (pending execution), CONFIRMED (successfully execution), FAILED (execution failed, nothing happened to your account)
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("timestamp")]
    public required long Timestamp { get; init; }

    [JsonPropertyName("txId")]
    public required long TxId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
