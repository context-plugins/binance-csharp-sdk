using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1AssetWalletBalanceResponse
{
    [JsonPropertyName("activate")]
    public required bool Activate { get; init; }

    [JsonPropertyName("balance")]
    public required string Balance { get; init; }

    [JsonPropertyName("walletName")]
    public required string WalletName { get; init; }
}
