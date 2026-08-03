using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SystemStatusResponse
{
    /// <summary>
    /// 0: normal, 1：system maintenance
    /// </summary>
    [JsonPropertyName("status")]
    public required int Status { get; init; }

    /// <summary>
    /// "normal", "system_maintenance"
    /// </summary>
    [JsonPropertyName("msg")]
    public required string Msg { get; init; }
}
