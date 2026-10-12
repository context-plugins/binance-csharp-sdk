using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Balance2
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("free")]
    public required long Free { get; init; }

    [JsonPropertyName("locked")]
    public required long Locked { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
