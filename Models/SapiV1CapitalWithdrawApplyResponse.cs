using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1CapitalWithdrawApplyResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }
}
