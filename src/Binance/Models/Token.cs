using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Token
{
    [JsonPropertyName("network")]
    public required string Network { get; init; }

    [JsonPropertyName("tokenId")]
    public required string TokenId { get; init; }

    [JsonPropertyName("contractAddress")]
    public required string ContractAddress { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
