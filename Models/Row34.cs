using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Row34
{
    /// <summary>
    /// BETH APR
    /// </summary>
    [JsonPropertyName("annualPercentageRate")]
    public required string AnnualPercentageRate { get; init; }

    /// <summary>
    /// BETH value per 1 WBETH
    /// </summary>
    [JsonPropertyName("exchangeRate")]
    public required string ExchangeRate { get; init; }

    [JsonPropertyName("time")]
    public required long Time { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
