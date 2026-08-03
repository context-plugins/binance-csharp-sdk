using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record List6
{
    [JsonPropertyName("network")]
    public required string Network { get; init; }

    [JsonPropertyName("contractAddress")]
    public required string ContractAddress { get; init; }

    [JsonPropertyName("tokenId")]
    public required string TokenId { get; init; }
}
