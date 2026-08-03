using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1RebateTaxQueryResponse
{
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("code")]
    public required string Code { get; init; }

    [JsonPropertyName("data")]
    public required Data23 Data { get; init; }
}
