using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1EthStakingWbethWrapResponse
{
    [JsonPropertyName("success")]
    public required bool Success { get; init; }

    [JsonPropertyName("wbethAmount")]
    public required string WbethAmount { get; init; }

    [JsonPropertyName("exchangeRate")]
    public required string ExchangeRate { get; init; }
}
