using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1AlgoFuturesOrderResponse
{
    [JsonPropertyName("algoId")]
    public required long AlgoId { get; init; }

    [JsonPropertyName("success")]
    public required bool Success { get; init; }

    [JsonPropertyName("code")]
    public required long Code { get; init; }

    [JsonPropertyName("msg")]
    public required string Msg { get; init; }
}
