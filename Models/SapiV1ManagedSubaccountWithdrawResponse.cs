using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1ManagedSubaccountWithdrawResponse
{
    [JsonPropertyName("tranId")]
    public required long TranId { get; init; }
}
