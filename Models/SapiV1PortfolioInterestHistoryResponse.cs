using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1PortfolioInterestHistoryResponse
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("interest")]
    public required string Interest { get; init; }

    [JsonPropertyName("interestAccruedTime")]
    public required long InterestAccruedTime { get; init; }

    [JsonPropertyName("interestRate")]
    public required string InterestRate { get; init; }

    [JsonPropertyName("principal")]
    public required string Principal { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
