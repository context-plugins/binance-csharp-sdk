using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1PortfolioRepayFuturesSwitchResponse1
{
    [JsonPropertyName("autoRepay")]
    public required bool AutoRepay { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
