using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Holdings
{
    [JsonPropertyName("wbethAmount")]
    public required string WbethAmount { get; init; }

    [JsonPropertyName("bethAmount")]
    public required string BethAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
