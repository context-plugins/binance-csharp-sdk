using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record TierAnnualPercentageRate
{
    [JsonPropertyName("0-5BTC")]
    public required double Btc05 { get; init; }

    [JsonPropertyName("5-10BTC")]
    public required double Btc510 { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
