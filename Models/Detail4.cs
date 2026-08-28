using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Detail4
{
    [JsonPropertyName("targetAsset")]
    public required string TargetAsset { get; init; }

    /// <summary>
    /// average price of the asset in USD
    /// </summary>
    [JsonPropertyName("averagePriceInUSD")]
    public required string AveragePriceInUsd { get; init; }

    /// <summary>
    /// total source asset invested for this target asset in equivilent of USD
    /// </summary>
    [JsonPropertyName("totalInvestedInUSD")]
    public required string TotalInvestedInUsd { get; init; }

    /// <summary>
    /// current invest
    /// </summary>
    [JsonPropertyName("currentInvestedInUSD")]
    public required string CurrentInvestedInUsd { get; init; }

    /// <summary>
    /// purchased amount of target asset
    /// </summary>
    [JsonPropertyName("purchasedAmount")]
    public required string PurchasedAmount { get; init; }

    /// <summary>
    /// PNL denominated in USD
    /// </summary>
    [JsonPropertyName("pnlInUSD")]
    public required string PnlInUsd { get; init; }

    /// <summary>
    /// ROI calculated in decimal
    /// </summary>
    [JsonPropertyName("roi")]
    public required string Roi { get; init; }

    /// <summary>
    /// asset allocation in the plan. If it's single plan, then it's 100
    /// </summary>
    [JsonPropertyName("percentage")]
    public required string Percentage { get; init; }

    [JsonPropertyName("availableAmount")]
    public required string AvailableAmount { get; init; }

    [JsonPropertyName("redeemedAmount")]
    public required string RedeemedAmount { get; init; }

    [JsonPropertyName("assetValueInUSD")]
    public required string AssetValueInUsd { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
