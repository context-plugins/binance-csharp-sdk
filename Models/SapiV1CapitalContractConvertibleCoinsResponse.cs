using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1CapitalContractConvertibleCoinsResponse
{
    [JsonPropertyName("convertEnabled")]
    public required bool ConvertEnabled { get; init; }

    [JsonPropertyName("coins")]
    public required IReadOnlyList<string> Coins { get; init; }

    [JsonPropertyName("exchangeRates")]
    public required ExchangeRates ExchangeRates { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
