using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record List5
{
    [JsonPropertyName("network")]
    public required string Network { get; init; }

    [JsonPropertyName("txID")]
    public required string TxId { get; init; }

    [JsonPropertyName("contractAdrress")]
    public required string ContractAdrress { get; init; }

    [JsonPropertyName("tokenId")]
    public required string TokenId { get; init; }

    [JsonPropertyName("timestamp")]
    public required long Timestamp { get; init; }

    [JsonPropertyName("fee")]
    public required double Fee { get; init; }

    [JsonPropertyName("feeAsset")]
    public required string FeeAsset { get; init; }
}
