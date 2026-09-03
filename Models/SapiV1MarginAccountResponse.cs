using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1MarginAccountResponse
{
    [JsonPropertyName("created")]
    public required bool Created { get; init; }

    [JsonPropertyName("borrowEnabled")]
    public required bool BorrowEnabled { get; init; }

    [JsonPropertyName("marginLevel")]
    public required string MarginLevel { get; init; }

    [JsonPropertyName("collateralMarginLevel")]
    public required string CollateralMarginLevel { get; init; }

    [JsonPropertyName("totalAssetOfBtc")]
    public required string TotalAssetOfBtc { get; init; }

    [JsonPropertyName("totalLiabilityOfBtc")]
    public required string TotalLiabilityOfBtc { get; init; }

    [JsonPropertyName("totalNetAssetOfBtc")]
    public required string TotalNetAssetOfBtc { get; init; }

    [JsonPropertyName("TotalCollateralValueInUSDT")]
    public required string TotalCollateralValueInUsdt { get; init; }

    [JsonPropertyName("tradeEnabled")]
    public required bool TradeEnabled { get; init; }

    [JsonPropertyName("transferInEnabled")]
    public required bool TransferInEnabled { get; init; }

    [JsonPropertyName("transferOutEnabled")]
    public required bool TransferOutEnabled { get; init; }

    [JsonPropertyName("accountType")]
    public required string AccountType { get; init; }

    [JsonPropertyName("userAssets")]
    public required IReadOnlyList<UserAsset> UserAssets { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
