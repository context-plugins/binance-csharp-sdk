using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1AccountInfoResponse
{
    [JsonPropertyName("vipLevel")]
    public required int VipLevel { get; init; }

    /// <summary>
    /// true or false for margin.
    /// </summary>
    [JsonPropertyName("isMarginEnabled")]
    public required bool IsMarginEnabled { get; init; }

    /// <summary>
    /// true or false for futures.
    /// </summary>
    [JsonPropertyName("isFutureEnabled")]
    public required bool IsFutureEnabled { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
