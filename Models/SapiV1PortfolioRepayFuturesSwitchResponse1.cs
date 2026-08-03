using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1PortfolioRepayFuturesSwitchResponse1
{
    [JsonPropertyName("autoRepay")]
    public required bool AutoRepay { get; init; }
}
