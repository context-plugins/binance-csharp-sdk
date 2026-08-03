using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Row47
{
    [JsonPropertyName("positionId")]
    public required string PositionId { get; init; }

    [JsonPropertyName("time")]
    public required long Time { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("lockPeriod")]
    public required string LockPeriod { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }
}
