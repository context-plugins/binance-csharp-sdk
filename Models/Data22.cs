using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Data22
{
    /// <summary>
    /// Enum：PAY(C2B Merchant Acquiring Payment), PAY_REFUND(C2B Merchant Acquiring Payment,refund), C2C(C2C Transfer Payment),CRYPTO_BOX(Crypto box), CRYPTO_BOX_RF(Crypto Box, refund), C2C_HOLDING(Transfer to new Binance user), C2C_HOLDING_RF(Transfer to new Binance user,refund), PAYOUT(B2C Disbursement Payment)
    /// </summary>
    [JsonPropertyName("orderType")]
    public required string OrderType { get; init; }

    [JsonPropertyName("transactionId")]
    public required string TransactionId { get; init; }

    [JsonPropertyName("transactionTime")]
    public required long TransactionTime { get; init; }

    /// <summary>
    /// order amount(up to 8 decimal places), positive is income, negative is expenditure
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    [JsonPropertyName("walletType")]
    public required int WalletType { get; init; }

    [JsonPropertyName("walletTypes")]
    public required IReadOnlyList<int> WalletTypes { get; init; }

    [JsonPropertyName("fundsDetail")]
    public required IReadOnlyList<FundsDetail> FundsDetail { get; init; }

    [JsonPropertyName("payerInfo")]
    public required PayerInfo PayerInfo { get; init; }

    [JsonPropertyName("receiverInfo")]
    public required ReceiverInfo ReceiverInfo { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
