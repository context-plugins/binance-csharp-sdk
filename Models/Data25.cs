using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Data25
{
    [JsonPropertyName("referenceNo")]
    public required string ReferenceNo { get; init; }

    [JsonPropertyName("code")]
    public required string Code { get; init; }

    [JsonPropertyName("expiredTime")]
    public required long ExpiredTime { get; init; }
}
