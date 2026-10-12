using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record TransferResult
{
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("fromAsset")]
    public required string FromAsset { get; init; }

    [JsonPropertyName("operateTime")]
    public required long OperateTime { get; init; }

    [JsonPropertyName("serviceChargeAmount")]
    public required string ServiceChargeAmount { get; init; }

    [JsonPropertyName("tranId")]
    public required long TranId { get; init; }

    [JsonPropertyName("transferedAmount")]
    public required string TransferedAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
