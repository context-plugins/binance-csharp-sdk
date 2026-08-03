using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1CopyTradingFuturesLeadSymbolResponse
{
    [JsonPropertyName("code")]
    public required string Code { get; init; }

    [JsonPropertyName("message")]
    public required string Message { get; init; }

    [JsonPropertyName("data")]
    public required Data31 Data { get; init; }
}
