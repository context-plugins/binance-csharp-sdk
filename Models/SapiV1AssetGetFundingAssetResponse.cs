using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1AssetGetFundingAssetResponse
{
    [JsonPropertyName("asset")]
    public required string Asset { get; init; }

    [JsonPropertyName("free")]
    public required string Free { get; init; }

    [JsonPropertyName("locked")]
    public required string Locked { get; init; }

    [JsonPropertyName("freeze")]
    public required string Freeze { get; init; }

    [JsonPropertyName("withdrawing")]
    public required string Withdrawing { get; init; }

    [JsonPropertyName("btcValuation")]
    public required string BtcValuation { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
