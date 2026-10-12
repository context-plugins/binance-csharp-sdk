using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record ApiV3TimeResponse
{
    [JsonPropertyName("serverTime")]
    public required long ServerTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
