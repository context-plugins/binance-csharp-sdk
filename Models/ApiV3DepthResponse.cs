using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record ApiV3DepthResponse
{
    [JsonPropertyName("lastUpdateId")]
    public required long LastUpdateId { get; init; }

    [JsonPropertyName("bids")]
    public required IReadOnlyList<IReadOnlyList<string>> Bids { get; init; }

    [JsonPropertyName("asks")]
    public required IReadOnlyList<IReadOnlyList<string>> Asks { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
