using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1MiningHashTransferConfigResponse
{
    [JsonPropertyName("code")]
    public required long Code { get; init; }

    [JsonPropertyName("msg")]
    public required string Msg { get; init; }

    /// <summary>
    /// Mining Account
    /// </summary>
    [JsonPropertyName("data")]
    public required long Data { get; init; }
}
