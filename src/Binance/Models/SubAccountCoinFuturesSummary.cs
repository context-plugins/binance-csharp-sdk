using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SubAccountCoinFuturesSummary
{
    [JsonPropertyName("deliveryAccountSummaryResp")]
    public required DeliveryAccountSummaryResp DeliveryAccountSummaryResp { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
