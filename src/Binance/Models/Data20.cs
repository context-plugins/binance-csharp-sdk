using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Data20
{
    [JsonPropertyName("day")]
    public required string Day { get; init; }

    [JsonPropertyName("url")]
    public required string Url { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
