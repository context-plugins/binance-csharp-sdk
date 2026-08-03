using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1ManagedSubaccountFetchFutureAssetResponse
{
    [JsonPropertyName("code")]
    public required int Code { get; init; }

    [JsonPropertyName("message")]
    public required string Message { get; init; }

    [JsonPropertyName("snapshotVos")]
    public required IReadOnlyList<SnapshotVo4> SnapshotVos { get; init; }
}
