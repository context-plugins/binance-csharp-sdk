using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record UserAssetDribbletDetail
{
    [JsonPropertyName("transId")]
    public required long TransId { get; init; }

    [JsonPropertyName("serviceChargeAmount")]
    public required string ServiceChargeAmount { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("operateTime")]
    public required long OperateTime { get; init; }

    [JsonPropertyName("transferedAmount")]
    public required string TransferedAmount { get; init; }

    [JsonPropertyName("fromAsset")]
    public required string FromAsset { get; init; }
}
