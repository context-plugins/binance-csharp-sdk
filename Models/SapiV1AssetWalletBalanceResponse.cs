using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1AssetWalletBalanceResponse
{
    [JsonPropertyName("activate")]
    public required bool Activate { get; init; }

    [JsonPropertyName("balance")]
    public required string Balance { get; init; }

    [JsonPropertyName("walletName")]
    public required string WalletName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
