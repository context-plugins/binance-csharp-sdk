using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record DeliveryAccountSummaryResp
{
    [JsonPropertyName("totalMarginBalanceOfBTC")]
    public required string TotalMarginBalanceOfBtc { get; init; }

    [JsonPropertyName("totalUnrealizedProfitOfBTC")]
    public required string TotalUnrealizedProfitOfBtc { get; init; }

    [JsonPropertyName("totalWalletBalanceOfBTC")]
    public required string TotalWalletBalanceOfBtc { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("subAccountList")]
    public required IReadOnlyList<SubAccountList1> SubAccountList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
