using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SnapshotFutures
{
    [JsonPropertyName("code")]
    public required long Code { get; init; }

    [JsonPropertyName("msg")]
    public required string Msg { get; init; }

    [JsonPropertyName("snapshotVos")]
    public required IReadOnlyList<SnapshotVo2> SnapshotVos { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
