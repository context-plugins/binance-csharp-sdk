using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Row35
{
    [JsonPropertyName("time")]
    public required long Time { get; init; }

    [JsonPropertyName("fromAsset")]
    public required string FromAsset { get; init; }

    [JsonPropertyName("fromAmount")]
    public required string FromAmount { get; init; }

    [JsonPropertyName("toAsset")]
    public required string ToAsset { get; init; }

    [JsonPropertyName("toAmount")]
    public required string ToAmount { get; init; }

    /// <summary>
    /// BETH amount per 1 WBETH
    /// </summary>
    [JsonPropertyName("exchangeRate")]
    public required string ExchangeRate { get; init; }

    /// <summary>
    /// PENDING, SUCCESS, FAILED
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }
}
