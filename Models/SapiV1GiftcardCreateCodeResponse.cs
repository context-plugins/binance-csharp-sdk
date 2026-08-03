using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1GiftcardCreateCodeResponse
{
    [JsonPropertyName("code")]
    public required string Code { get; init; }

    [JsonPropertyName("message")]
    public required string Message { get; init; }

    [JsonPropertyName("data")]
    public required Data25 Data { get; init; }

    [JsonPropertyName("success")]
    public required bool Success { get; init; }
}
