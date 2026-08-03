using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1MiningPaymentOtherResponse
{
    [JsonPropertyName("code")]
    public required long Code { get; init; }

    [JsonPropertyName("msg")]
    public required string Msg { get; init; }

    [JsonPropertyName("data")]
    public required Data14 Data { get; init; }
}
