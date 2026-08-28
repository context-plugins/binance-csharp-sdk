using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Extend
{
    [JsonPropertyName("institutionName")]
    public required string InstitutionName { get; init; }

    [JsonPropertyName("cardNumber")]
    public required string CardNumber { get; init; }

    [JsonPropertyName("digitalWalletId")]
    public required string DigitalWalletId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
