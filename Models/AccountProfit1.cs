using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record AccountProfit1
{
    [JsonPropertyName("time")]
    public required long Time { get; init; }

    [JsonPropertyName("coinName")]
    public required string CoinName { get; init; }

    /// <summary>
    /// 0:Referral 1:Refund 2:Rebate
    /// </summary>
    [JsonPropertyName("type")]
    public required int Type { get; init; }

    /// <summary>
    /// puid
    /// </summary>
    [JsonPropertyName("puid")]
    public required int Puid { get; init; }

    /// <summary>
    /// Mining account
    /// </summary>
    [JsonPropertyName("subName")]
    public required string SubName { get; init; }

    [JsonPropertyName("amount")]
    public required double Amount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
