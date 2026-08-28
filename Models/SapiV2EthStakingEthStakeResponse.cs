using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV2EthStakingEthStakeResponse
{
    [JsonPropertyName("success")]
    public required bool Success { get; init; }

    [JsonPropertyName("wbethAmount")]
    public required string WbethAmount { get; init; }

    /// <summary>
    /// ETH amount per 1 WBETH
    /// </summary>
    [JsonPropertyName("conversionRatio")]
    public required string ConversionRatio { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
