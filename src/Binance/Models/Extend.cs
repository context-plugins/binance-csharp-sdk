using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

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
