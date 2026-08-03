using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1ManagedSubaccountAccountSnapshotResponse
{
    [JsonPropertyName("code")]
    public required int Code { get; init; }

    [JsonPropertyName("msg")]
    public required string Msg { get; init; }

    [JsonPropertyName("snapshotVos")]
    public required IReadOnlyList<SnapshotVo> SnapshotVos { get; init; }
}
