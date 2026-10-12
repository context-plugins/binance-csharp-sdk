using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1PortfolioRepayFuturesNegativeBalanceResponse
{
    [JsonPropertyName("msg")]
    public required string Msg { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
