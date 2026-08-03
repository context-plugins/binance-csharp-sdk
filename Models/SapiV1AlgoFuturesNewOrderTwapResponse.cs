using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1AlgoFuturesNewOrderTwapResponse
{
    [JsonPropertyName("clientAlgoId")]
    public required string ClientAlgoId { get; init; }

    [JsonPropertyName("success")]
    public required bool Success { get; init; }

    [JsonPropertyName("code")]
    public required long Code { get; init; }

    [JsonPropertyName("msg")]
    public required string Msg { get; init; }
}
