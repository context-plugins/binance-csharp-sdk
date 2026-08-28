using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1PortfolioRepayFuturesSwitchResponse1
{
    [JsonPropertyName("autoRepay")]
    public required bool AutoRepay { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
