using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1CapitalConfigGetallResponse
{
    [JsonPropertyName("coin")]
    public required string Coin { get; init; }

    [JsonPropertyName("depositAllEnable")]
    public required bool DepositAllEnable { get; init; }

    [JsonPropertyName("free")]
    public required string Free { get; init; }

    [JsonPropertyName("freeze")]
    public required string Freeze { get; init; }

    [JsonPropertyName("ipoable")]
    public required string Ipoable { get; init; }

    [JsonPropertyName("ipoing")]
    public required string Ipoing { get; init; }

    [JsonPropertyName("isLegalMoney")]
    public required bool IsLegalMoney { get; init; }

    [JsonPropertyName("locked")]
    public required string Locked { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("networkList")]
    public required IReadOnlyList<NetworkList> NetworkList { get; init; }

    [JsonPropertyName("storage")]
    public required string Storage { get; init; }

    [JsonPropertyName("trading")]
    public required bool Trading { get; init; }

    [JsonPropertyName("withdrawAllEnable")]
    public required bool WithdrawAllEnable { get; init; }

    [JsonPropertyName("withdrawing")]
    public required string Withdrawing { get; init; }
}
