using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record ErrorError
{
    /// <summary>
    /// Error code
    /// </summary>
    [JsonPropertyName("code")]
    public required long Code { get; init; }

    /// <summary>
    /// Error message
    /// </summary>
    [JsonPropertyName("msg")]
    public required string Msg { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
