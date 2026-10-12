using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1LendingAutoInvestRedeemHistoryResponse
{
    [JsonPropertyName("indexId")]
    public required long IndexId { get; init; }

    [JsonPropertyName("indexName")]
    public required string IndexName { get; init; }

    [JsonPropertyName("redemptionId")]
    public required long RedemptionId { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("redemptionDateTime")]
    public required long RedemptionDateTime { get; init; }

    [JsonPropertyName("transactionFee")]
    public required string TransactionFee { get; init; }

    [JsonPropertyName("transactionFeeUnit")]
    public required string TransactionFeeUnit { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
