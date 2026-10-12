using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record OtherProfit
{
    /// <summary>
    /// Mining date
    /// </summary>
    [JsonPropertyName("time")]
    public required long Time { get; init; }

    /// <summary>
    /// Coin Name
    /// </summary>
    [JsonPropertyName("coinName")]
    public required string CoinName { get; init; }

    /// <summary>
    /// 1: Merged Mining, 2: Activity Bonus, 3:Rebate 4:Smart Pool 6:Income Transfer 7:Pool Savings
    /// </summary>
    [JsonPropertyName("type")]
    public required int Type { get; init; }

    [JsonPropertyName("profitAmount")]
    public required double ProfitAmount { get; init; }

    /// <summary>
    /// 0:Unpaid, 1:Paying  2：Paid
    /// </summary>
    [JsonPropertyName("status")]
    public required int Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
