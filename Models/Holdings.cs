using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Holdings
{
    [JsonPropertyName("wbethAmount")]
    public required string WbethAmount { get; init; }

    [JsonPropertyName("bethAmount")]
    public required string BethAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
