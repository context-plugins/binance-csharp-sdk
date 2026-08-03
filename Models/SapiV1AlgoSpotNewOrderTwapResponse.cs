using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1AlgoSpotNewOrderTwapResponse
{
    [JsonPropertyName("clientAlgoId")]
    public required string ClientAlgoId { get; init; }

    [JsonPropertyName("success")]
    public required bool Success { get; init; }

    [JsonPropertyName("code")]
    public required int Code { get; init; }

    [JsonPropertyName("msg")]
    public required string Msg { get; init; }
}
