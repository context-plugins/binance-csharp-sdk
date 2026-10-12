using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1LendingAutoInvestHistoryListResponse
{
    [JsonPropertyName("id")]
    public required long Id { get; init; }

    [JsonPropertyName("targetAsset")]
    public required string TargetAsset { get; init; }

    [JsonPropertyName("planType")]
    public required string PlanType { get; init; }

    [JsonPropertyName("planName")]
    public required string PlanName { get; init; }

    [JsonPropertyName("planId")]
    public required long PlanId { get; init; }

    [JsonPropertyName("transactionDateTime")]
    public required long TransactionDateTime { get; init; }

    [JsonPropertyName("transactionStatus")]
    public required string TransactionStatus { get; init; }

    [JsonPropertyName("failedType")]
    public required string FailedType { get; init; }

    [JsonPropertyName("sourceAsset")]
    public required string SourceAsset { get; init; }

    [JsonPropertyName("sourceAssetAmount")]
    public required string SourceAssetAmount { get; init; }

    [JsonPropertyName("targetAssetAmount")]
    public required string TargetAssetAmount { get; init; }

    [JsonPropertyName("sourceWallet")]
    public required string SourceWallet { get; init; }

    [JsonPropertyName("flexibleUsed")]
    public required string FlexibleUsed { get; init; }

    [JsonPropertyName("transactionFee")]
    public required string TransactionFee { get; init; }

    [JsonPropertyName("transactionFeeUnit")]
    public required string TransactionFeeUnit { get; init; }

    [JsonPropertyName("executionPrice")]
    public required string ExecutionPrice { get; init; }

    [JsonPropertyName("executionType")]
    public required string ExecutionType { get; init; }

    [JsonPropertyName("subscriptionCycle")]
    public required string SubscriptionCycle { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
