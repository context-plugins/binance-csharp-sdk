using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1LendingCustomizedFixedPurchaseResponse
{
    [JsonPropertyName("purchaseId")]
    public required string PurchaseId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
