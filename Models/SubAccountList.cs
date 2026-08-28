using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SubAccountList
{
    [JsonPropertyName("email")]
    public required string Email { get; init; }

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

    /// <summary>
    /// The sum of BUSD and USDT
    /// </summary>
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
