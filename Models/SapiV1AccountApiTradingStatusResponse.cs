using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1AccountApiTradingStatusResponse
{
    [JsonPropertyName("data")]
    public required Data4 Data { get; init; }
}
