using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SubAccountUsdtfuturesDetails
{
    [JsonPropertyName("futureAccountResp")]
    public required FutureAccountResp FutureAccountResp { get; init; }
}
