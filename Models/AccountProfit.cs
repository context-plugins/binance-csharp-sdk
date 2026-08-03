using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record AccountProfit
{
    /// <summary>
    /// Mining date
    /// </summary>
    [JsonPropertyName("time")]
    public required long Time { get; init; }

    /// <summary>
    /// 0:Mining Wallet,5:Mining Address,7:Pool Savings,8:Transferred,31:Income Transfer ,32:Hashrate Resale-Mining Wallet 33:Hashrate Resale-Pool Savings
    /// </summary>
    [JsonPropertyName("type")]
    public required long Type { get; init; }

    /// <summary>
    /// Transferred Hashrate
    /// </summary>
    [JsonPropertyName("hashTransfer")]
    public required int HashTransfer { get; init; }

    /// <summary>
    /// Transferred Income
    /// </summary>
    [JsonPropertyName("transferAmount")]
    public required double TransferAmount { get; init; }

    /// <summary>
    /// Daily Hashrate
    /// </summary>
    [JsonPropertyName("dayHashRate")]
    public required long DayHashRate { get; init; }

    /// <summary>
    /// Earnings Amount
    /// </summary>
    [JsonPropertyName("profitAmount")]
    public required double ProfitAmount { get; init; }

    /// <summary>
    /// Coin Type
    /// </summary>
    [JsonPropertyName("coinName")]
    public required string CoinName { get; init; }

    /// <summary>
    /// Status：0:Unpaid, 1:Paying  2：Paid
    /// </summary>
    [JsonPropertyName("status")]
    public required int Status { get; init; }
}
