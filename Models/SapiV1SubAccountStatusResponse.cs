using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1SubAccountStatusResponse
{
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    [JsonPropertyName("isSubUserEnabled")]
    public required bool IsSubUserEnabled { get; init; }

    [JsonPropertyName("isUserActive")]
    public required bool IsUserActive { get; init; }

    /// <summary>
    /// sub account create time
    /// </summary>
    [JsonPropertyName("insertTime")]
    public required long InsertTime { get; init; }

    [JsonPropertyName("isMarginEnabled")]
    public required bool IsMarginEnabled { get; init; }

    [JsonPropertyName("isFutureEnabled")]
    public required bool IsFutureEnabled { get; init; }

    /// <summary>
    /// user mobile number
    /// </summary>
    [JsonPropertyName("mobile")]
    public required long Mobile { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
