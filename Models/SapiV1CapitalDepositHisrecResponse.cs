using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1CapitalDepositHisrecResponse
{
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("coin")]
    public required string Coin { get; init; }

    [JsonPropertyName("network")]
    public required string Network { get; init; }

    [JsonPropertyName("status")]
    public required int Status { get; init; }

    [JsonPropertyName("address")]
    public required string Address { get; init; }

    [JsonPropertyName("addressTag")]
    public required string AddressTag { get; init; }

    [JsonPropertyName("txId")]
    public required string TxId { get; init; }

    [JsonPropertyName("insertTime")]
    public required long InsertTime { get; init; }

    [JsonPropertyName("transferType")]
    public required int TransferType { get; init; }

    /// <summary>
    /// confirm times for unlocking
    /// </summary>
    [JsonPropertyName("unlockConfirm")]
    public required string UnlockConfirm { get; init; }

    [JsonPropertyName("confirmTimes")]
    public required string ConfirmTimes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
