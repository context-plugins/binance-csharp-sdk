using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1ManagedSubaccountAssetResponse
{
    [JsonPropertyName("coin")]
    public required string Coin { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("totalBalance")]
    public required string TotalBalance { get; init; }

    [JsonPropertyName("availableBalance")]
    public required string AvailableBalance { get; init; }

    [JsonPropertyName("inOrder")]
    public required string InOrder { get; init; }

    [JsonPropertyName("btcValue")]
    public required string BtcValue { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
