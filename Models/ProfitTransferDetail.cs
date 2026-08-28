using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record ProfitTransferDetail
{
    /// <summary>
    /// Transfer out of sub-account
    /// </summary>
    [JsonPropertyName("poolUsername")]
    public required string PoolUsername { get; init; }

    /// <summary>
    /// Transfer into subaccount
    /// </summary>
    [JsonPropertyName("toPoolUsername")]
    public required string ToPoolUsername { get; init; }

    /// <summary>
    /// Transfer algorithm
    /// </summary>
    [JsonPropertyName("algoName")]
    public required string AlgoName { get; init; }

    /// <summary>
    /// Transferred Hashrate quantity
    /// </summary>
    [JsonPropertyName("hashRate")]
    public required long HashRate { get; init; }

    /// <summary>
    /// Transfer date
    /// </summary>
    [JsonPropertyName("day")]
    public required long Day { get; init; }

    /// <summary>
    /// Transfer income
    /// </summary>
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }

    [JsonPropertyName("coinName")]
    public required string CoinName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
