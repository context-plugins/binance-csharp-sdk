using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SubAccountUsdtFuturesDetails
{
    [JsonPropertyName("futureAccountResp")]
    public required FutureAccountResp FutureAccountResp { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
