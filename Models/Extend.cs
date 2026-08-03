using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Extend
{
    [JsonPropertyName("institutionName")]
    public required string InstitutionName { get; init; }

    [JsonPropertyName("cardNumber")]
    public required string CardNumber { get; init; }

    [JsonPropertyName("digitalWalletId")]
    public required string DigitalWalletId { get; init; }
}
