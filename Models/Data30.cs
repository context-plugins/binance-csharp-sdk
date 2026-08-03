using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Data30
{
    [JsonPropertyName("isLeadTrader")]
    public required bool IsLeadTrader { get; init; }

    [JsonPropertyName("time")]
    public required long Time { get; init; }
}
