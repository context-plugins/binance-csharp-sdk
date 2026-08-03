using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SnapshotMargin
{
    [JsonPropertyName("code")]
    public required long Code { get; init; }

    [JsonPropertyName("msg")]
    public required string Msg { get; init; }

    [JsonPropertyName("snapshotVos")]
    public required IReadOnlyList<SnapshotVo1> SnapshotVos { get; init; }
}
