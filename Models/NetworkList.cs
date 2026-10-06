using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record NetworkList
{
    [JsonPropertyName("addressRegex")]
    public required string AddressRegex { get; init; }

    [JsonPropertyName("coin")]
    public required string Coin { get; init; }

    /// <summary>
    /// shown only when "depositEnable" is false.
    /// </summary>
    [JsonPropertyName("depositDesc")]
    public required string DepositDesc { get; init; }

    [JsonPropertyName("depositEnable")]
    public required bool DepositEnable { get; init; }

    [JsonPropertyName("isDefault")]
    public required bool IsDefault { get; init; }

    [JsonPropertyName("memoRegex")]
    public required string MemoRegex { get; init; }

    /// <summary>
    /// min number for balance confirmation.
    /// </summary>
    [JsonPropertyName("minConfirm")]
    public required long MinConfirm { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("network")]
    public required string Network { get; init; }

    [JsonPropertyName("specialTips")]
    public required string SpecialTips { get; init; }

    /// <summary>
    /// confirmation number for balance unlock.
    /// </summary>
    [JsonPropertyName("unLockConfirm")]
    public required long UnLockConfirm { get; init; }

    /// <summary>
    /// shown only when "withdrawEnable" is false
    /// </summary>
    [JsonPropertyName("withdrawDesc")]
    public required string WithdrawDesc { get; init; }

    [JsonPropertyName("withdrawEnable")]
    public required bool WithdrawEnable { get; init; }

    [JsonPropertyName("withdrawFee")]
    public required string WithdrawFee { get; init; }

    [JsonPropertyName("withdrawIntegerMultiple")]
    public required string WithdrawIntegerMultiple { get; init; }

    [JsonPropertyName("withdrawMax")]
    public required string WithdrawMax { get; init; }

    [JsonPropertyName("withdrawMin")]
    public required string WithdrawMin { get; init; }

    [JsonPropertyName("sameAddress")]
    public required bool SameAddress { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
