using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Account
{
    [JsonPropertyName("makerCommission")]
    public required long MakerCommission { get; init; }

    [JsonPropertyName("takerCommission")]
    public required long TakerCommission { get; init; }

    [JsonPropertyName("buyerCommission")]
    public required long BuyerCommission { get; init; }

    [JsonPropertyName("sellerCommission")]
    public required long SellerCommission { get; init; }

    [JsonPropertyName("commissionRates")]
    public required CommissionRates CommissionRates { get; init; }

    [JsonPropertyName("canTrade")]
    public required bool CanTrade { get; init; }

    [JsonPropertyName("canWithdraw")]
    public required bool CanWithdraw { get; init; }

    [JsonPropertyName("canDeposit")]
    public required bool CanDeposit { get; init; }

    [JsonPropertyName("brokered")]
    public required bool Brokered { get; init; }

    [JsonPropertyName("requireSelfTradePrevention")]
    public required bool RequireSelfTradePrevention { get; init; }

    [JsonPropertyName("preventSor")]
    public required bool PreventSor { get; init; }

    [JsonPropertyName("updateTime")]
    public required long UpdateTime { get; init; }

    [JsonPropertyName("accountType")]
    public required string AccountType { get; init; }

    [JsonPropertyName("balances")]
    public required IReadOnlyList<Balance> Balances { get; init; }

    [JsonPropertyName("permissions")]
    public required IReadOnlyList<string> Permissions { get; init; }

    [JsonPropertyName("uid")]
    public required long Uid { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
