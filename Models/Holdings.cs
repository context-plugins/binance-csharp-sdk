using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Holdings
{
    [JsonPropertyName("wbethAmount")]
    public required string WbethAmount { get; init; }

    [JsonPropertyName("bethAmount")]
    public required string BethAmount { get; init; }
}
