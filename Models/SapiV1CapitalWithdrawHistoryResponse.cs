using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1CapitalWithdrawHistoryResponse
{
    [JsonPropertyName("address")]
    public required string Address { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("applyTime")]
    public required string ApplyTime { get; init; }

    [JsonPropertyName("coin")]
    public required string Coin { get; init; }

    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// will not be returned if there's no withdrawOrderId for this withdraw.
    /// </summary>
    [JsonPropertyName("withdrawOrderId")]
    public required string WithdrawOrderId { get; init; }

    [JsonPropertyName("network")]
    public required string Network { get; init; }

    /// <summary>
    /// 1 for internal transfer, 0 for external transfer
    /// </summary>
    [JsonPropertyName("transferType")]
    public required int TransferType { get; init; }

    [JsonPropertyName("status")]
    public required int Status { get; init; }

    [JsonPropertyName("transactionFee")]
    public required string TransactionFee { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("confirmNo")]
    public int? ConfirmNo { get; init; }

    /// <summary>
    /// Reason for withdrawal failure
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("info")]
    public string? Info { get; init; }

    [JsonPropertyName("txId")]
    public required string TxId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
