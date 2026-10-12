using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Ctr
{
    [JsonPropertyName("minWithdrawAmount")]
    public required string MinWithdrawAmount { get; init; }

    /// <summary>
    /// deposit status (false if ALL of networks' are false)
    /// </summary>
    [JsonPropertyName("depositStatus")]
    public required bool DepositStatus { get; init; }

    [JsonPropertyName("withdrawFee")]
    public required long WithdrawFee { get; init; }

    /// <summary>
    /// withdrawStatus status (false if ALL of networks' are false)
    /// </summary>
    [JsonPropertyName("withdrawStatus")]
    public required bool WithdrawStatus { get; init; }

    [JsonPropertyName("depositTip")]
    public required string DepositTip { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
