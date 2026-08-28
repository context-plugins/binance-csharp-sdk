using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record TransactionDetail
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("transactionDateTime")]
    public required long TransactionDateTime { get; init; }

    [JsonPropertyName("rebalanceDirection")]
    public required string RebalanceDirection { get; init; }

    [JsonPropertyName("rebalanceAmount")]
    public required string RebalanceAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
