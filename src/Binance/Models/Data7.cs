using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Data7
{
    [JsonPropertyName("orderNo")]
    public required string OrderNo { get; init; }

    [JsonPropertyName("fiatCurrency")]
    public required string FiatCurrency { get; init; }

    [JsonPropertyName("indicatedAmount")]
    public required string IndicatedAmount { get; init; }

    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("totalFee")]
    public required string TotalFee { get; init; }

    [JsonPropertyName("method")]
    public required string Method { get; init; }

    /// <summary>
    /// Processing, Failed, Successful, Finished, Refunding, Refunded, Refund Failed, Order Partial credit Stopped
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("createTime")]
    public required long CreateTime { get; init; }

    [JsonPropertyName("updateTime")]
    public required long UpdateTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
