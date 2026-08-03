using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Data26
{
    [JsonPropertyName("token")]
    public required string Token { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("referenceNo")]
    public required string ReferenceNo { get; init; }

    [JsonPropertyName("identityNo")]
    public required string IdentityNo { get; init; }
}
