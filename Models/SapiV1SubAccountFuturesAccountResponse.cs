using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1SubAccountFuturesAccountResponse
{
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("assets")]
    public required IReadOnlyList<Assets1> Assets { get; init; }

    [JsonPropertyName("canDeposit")]
    public required bool CanDeposit { get; init; }

    [JsonPropertyName("canTrade")]
    public required bool CanTrade { get; init; }

    [JsonPropertyName("canWithdraw")]
    public required bool CanWithdraw { get; init; }

    [JsonPropertyName("feeTier")]
    public required long FeeTier { get; init; }

    [JsonPropertyName("maxWithdrawAmount")]
    public required string MaxWithdrawAmount { get; init; }

    [JsonPropertyName("totalInitialMargin")]
    public required string TotalInitialMargin { get; init; }

    [JsonPropertyName("totalMaintenanceMargin")]
    public required string TotalMaintenanceMargin { get; init; }

    [JsonPropertyName("totalMarginBalance")]
    public required string TotalMarginBalance { get; init; }

    [JsonPropertyName("totalOpenOrderInitialMargin")]
    public required string TotalOpenOrderInitialMargin { get; init; }

    [JsonPropertyName("totalPositionInitialMargin")]
    public required string TotalPositionInitialMargin { get; init; }

    [JsonPropertyName("totalUnrealizedProfit")]
    public required string TotalUnrealizedProfit { get; init; }

    [JsonPropertyName("totalWalletBalance")]
    public required string TotalWalletBalance { get; init; }

    [JsonPropertyName("updateTime")]
    public required long UpdateTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
