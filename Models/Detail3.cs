using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Detail3
{
    [JsonPropertyName("targetAsset")]
    public required string TargetAsset { get; init; }

    [JsonPropertyName("averagePriceInUSD")]
    public required string AveragePriceInUsd { get; init; }

    [JsonPropertyName("totalInvestedInUSD")]
    public required string TotalInvestedInUsd { get; init; }

    [JsonPropertyName("purchasedAmount")]
    public required string PurchasedAmount { get; init; }

    [JsonPropertyName("purchasedAmountUnit")]
    public required string PurchasedAmountUnit { get; init; }

    [JsonPropertyName("pnlInUSD")]
    public required string PnlInUsd { get; init; }

    [JsonPropertyName("roi")]
    public required string Roi { get; init; }

    [JsonPropertyName("percentage")]
    public required string Percentage { get; init; }

    [JsonPropertyName("assetStatus")]
    public required string AssetStatus { get; init; }

    [JsonPropertyName("availableAmount")]
    public required string AvailableAmount { get; init; }

    [JsonPropertyName("availableAmountUnit")]
    public required string AvailableAmountUnit { get; init; }

    [JsonPropertyName("redeemedAmout")]
    public required string RedeemedAmout { get; init; }

    [JsonPropertyName("redeemedAmoutUnit")]
    public required string RedeemedAmoutUnit { get; init; }

    [JsonPropertyName("assetValueInUSD")]
    public required string AssetValueInUsd { get; init; }
}
