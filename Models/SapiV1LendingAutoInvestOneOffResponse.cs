using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1LendingAutoInvestOneOffResponse
{
    [JsonPropertyName("transactionId")]
    public required long TransactionId { get; init; }

    [JsonPropertyName("waitSecond")]
    public required int WaitSecond { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
