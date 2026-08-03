using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1LendingCustomizedFixedPurchaseResponse
{
    [JsonPropertyName("purchaseId")]
    public required string PurchaseId { get; init; }
}
