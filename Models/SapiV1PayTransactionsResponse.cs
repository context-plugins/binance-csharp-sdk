using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1PayTransactionsResponse
{
    [JsonPropertyName("code")]
    public required string Code { get; init; }

    [JsonPropertyName("message")]
    public required string Message { get; init; }

    [JsonPropertyName("data")]
    public required IReadOnlyList<Data22> Data { get; init; }

    [JsonPropertyName("success")]
    public required bool Success { get; init; }
}
