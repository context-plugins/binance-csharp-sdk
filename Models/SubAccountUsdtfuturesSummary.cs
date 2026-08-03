using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SubAccountUsdtfuturesSummary
{
    [JsonPropertyName("futureAccountSummaryResp")]
    public required FutureAccountSummaryResp FutureAccountSummaryResp { get; init; }
}
