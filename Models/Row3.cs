using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Row3
{
    [JsonPropertyName("isolatedSymbol")]
    public required string IsolatedSymbol { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("interest")]
    public required string Interest { get; init; }

    [JsonPropertyName("interestAccuredTime")]
    public required long InterestAccuredTime { get; init; }

    [JsonPropertyName("interestRate")]
    public required string InterestRate { get; init; }

    [JsonPropertyName("principal")]
    public required string Principal { get; init; }

    [JsonPropertyName("type")]
    public required string Type { get; init; }
}
