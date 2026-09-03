using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SubAccountUsdtFuturesSummary
{
    [JsonPropertyName("futureAccountSummaryResp")]
    public required FutureAccountSummaryResp FutureAccountSummaryResp { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
