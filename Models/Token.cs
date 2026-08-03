using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Token
{
    [JsonPropertyName("network")]
    public required string Network { get; init; }

    [JsonPropertyName("tokenId")]
    public required string TokenId { get; init; }

    [JsonPropertyName("contractAddress")]
    public required string ContractAddress { get; init; }
}
