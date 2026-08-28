using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Row40
{
    [JsonPropertyName("totalAmount")]
    public required string TotalAmount { get; init; }

    [JsonPropertyName("tierAnnualPercentageRate")]
    public required TierAnnualPercentageRate TierAnnualPercentageRate { get; init; }

    [JsonPropertyName("latestAnnualPercentageRate")]
    public required string LatestAnnualPercentageRate { get; init; }

    [JsonPropertyName("yesterdayAirdropPercentageRate")]
    public required string YesterdayAirdropPercentageRate { get; init; }

    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("airDropAsset")]
    public required string AirDropAsset { get; init; }

    [JsonPropertyName("canRedeem")]
    public required bool CanRedeem { get; init; }

    [JsonPropertyName("collateralAmount")]
    public required string CollateralAmount { get; init; }

    [JsonPropertyName("productId")]
    public required string ProductId { get; init; }

    [JsonPropertyName("yesterdayRealTimeRewards")]
    public required string YesterdayRealTimeRewards { get; init; }

    [JsonPropertyName("cumulativeBonusRewards")]
    public required string CumulativeBonusRewards { get; init; }

    [JsonPropertyName("cumulativeRealTimeRewards")]
    public required string CumulativeRealTimeRewards { get; init; }

    [JsonPropertyName("cumulativeTotalRewards")]
    public required string CumulativeTotalRewards { get; init; }

    [JsonPropertyName("autoSubscribe")]
    public required bool AutoSubscribe { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
