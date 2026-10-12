using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SubAccountUsdtFuturesSummary
{
    [JsonPropertyName("futureAccountSummaryResp")]
    public required FutureAccountSummaryResp FutureAccountSummaryResp { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
