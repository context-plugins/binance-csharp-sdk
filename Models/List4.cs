using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record List4
{
    [JsonPropertyName("network")]
    public required string Network { get; init; }

    [JsonPropertyName("txID")]
    public required int? TxId { get; init; }

    [JsonPropertyName("contractAdrress")]
    public required string ContractAdrress { get; init; }

    [JsonPropertyName("tokenId")]
    public required string TokenId { get; init; }

    [JsonPropertyName("timestamp")]
    public required long Timestamp { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
