using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SubAccountCoinfuturesSummary
{
    [JsonPropertyName("deliveryAccountSummaryResp")]
    public required DeliveryAccountSummaryResp DeliveryAccountSummaryResp { get; init; }
}
