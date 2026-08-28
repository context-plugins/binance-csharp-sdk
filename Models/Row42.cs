using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Row42
{
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("time")]
    public required long Time { get; init; }

    [JsonPropertyName("purchaseId")]
    public required long PurchaseId { get; init; }

    [JsonPropertyName("productId")]
    public required string ProductId { get; init; }

    /// <summary>
    /// AUTO for auto subscribe, NORMAL for normal subscription, CONVERT for Locked to Flexible, LOAN for flexible loan collateral, AI for Auto Invest subscribe, TRANSFER for Locked Savings to Flexible
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <summary>
    /// SPOT, FUNDING, SPOTANDFUNDING
    /// </summary>
    [JsonPropertyName("sourceAccount")]
    public required string SourceAccount { get; init; }

    /// <summary>
    /// Display if sourceAccount is SPOTANDFUNDING
    /// </summary>
    [JsonPropertyName("amtFromSpot")]
    public required string AmtFromSpot { get; init; }

    /// <summary>
    /// Display if sourceAccount is SPOTANDFUNDING
    /// </summary>
    [JsonPropertyName("amtFromFunding")]
    public required string AmtFromFunding { get; init; }

    /// <summary>
    /// PURCHASING/SUCCESS/FAILED
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
