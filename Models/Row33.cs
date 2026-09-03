using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Row33
{
    [JsonPropertyName("time")]
    public required long Time { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    /// <summary>
    /// BETH holding balance
    /// </summary>
    [JsonPropertyName("holding")]
    public required string Holding { get; init; }

    /// <summary>
    /// Distributed rewards
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// 0.5 means 50% here
    /// </summary>
    [JsonPropertyName("annualPercentageRate")]
    public required string AnnualPercentageRate { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
