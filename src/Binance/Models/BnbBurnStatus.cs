using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record BnbBurnStatus
{
    [JsonPropertyName("spotBNBBurn")]
    public required bool SpotBnbBurn { get; init; }

    [JsonPropertyName("interestBNBBurn")]
    public required bool InterestBnbBurn { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
