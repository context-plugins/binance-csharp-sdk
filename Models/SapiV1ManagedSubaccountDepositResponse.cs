using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1ManagedSubaccountDepositResponse
{
    [JsonPropertyName("tranId")]
    public required long TranId { get; init; }
}
