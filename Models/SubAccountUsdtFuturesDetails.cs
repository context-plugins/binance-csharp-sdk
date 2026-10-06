using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SubAccountUsdtFuturesDetails
{
    [JsonPropertyName("futureAccountResp")]
    public required FutureAccountResp FutureAccountResp { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
