using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1CapitalContractConvertibleCoinsResponse
{
    [JsonPropertyName("convertEnabled")]
    public required bool ConvertEnabled { get; init; }

    [JsonPropertyName("coins")]
    public required IReadOnlyList<string> Coins { get; init; }

    [JsonPropertyName("exchangeRates")]
    public required ExchangeRates ExchangeRates { get; init; }
}
