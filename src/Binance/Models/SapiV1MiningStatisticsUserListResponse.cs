using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1MiningStatisticsUserListResponse
{
    [JsonPropertyName("code")]
    public required long Code { get; init; }

    [JsonPropertyName("msg")]
    public required string Msg { get; init; }

    [JsonPropertyName("data")]
    public required IReadOnlyList<Data18> Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
