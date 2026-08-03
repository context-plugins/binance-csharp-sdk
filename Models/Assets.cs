using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Assets
{
    [JsonPropertyName("MATIC")]
    public required string Matic { get; init; }

    [JsonPropertyName("STPT")]
    public required string Stpt { get; init; }

    [JsonPropertyName("TVK")]
    public required string Tvk { get; init; }

    [JsonPropertyName("SHIB")]
    public required string Shib { get; init; }
}
