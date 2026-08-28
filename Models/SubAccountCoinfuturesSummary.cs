using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SubAccountCoinFuturesSummary
{
    [JsonPropertyName("deliveryAccountSummaryResp")]
    public required DeliveryAccountSummaryResp DeliveryAccountSummaryResp { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
