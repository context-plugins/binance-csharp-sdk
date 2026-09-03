using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1LendingAutoInvestRebalanceHistoryResponse
{
    [JsonPropertyName("indexId")]
    public required long IndexId { get; init; }

    [JsonPropertyName("indexName")]
    public required string IndexName { get; init; }

    [JsonPropertyName("rebalanceId")]
    public required long RebalanceId { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("rebalanceFee")]
    public required string RebalanceFee { get; init; }

    [JsonPropertyName("rebalanceFeeUnit")]
    public required string RebalanceFeeUnit { get; init; }

    [JsonPropertyName("transactionDetails")]
    public required IReadOnlyList<TransactionDetail> TransactionDetails { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
