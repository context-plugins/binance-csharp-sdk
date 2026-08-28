using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1EthStakingEthRedeemResponse
{
    [JsonPropertyName("success")]
    public required bool Success { get; init; }

    [JsonPropertyName("arrivalTime")]
    public required long ArrivalTime { get; init; }

    [JsonPropertyName("ethAmount")]
    public required string EthAmount { get; init; }

    [JsonPropertyName("conversionRatio")]
    public required string ConversionRatio { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
