using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record SapiV1SubAccountTransactionStatisticsResponse
{
    [JsonPropertyName("recent30BtcTotal")]
    public required string Recent30BtcTotal { get; init; }

    [JsonPropertyName("recent30BtcFuturesTotal")]
    public required string Recent30BtcFuturesTotal { get; init; }

    [JsonPropertyName("recent30BtcMarginTotal")]
    public required string Recent30BtcMarginTotal { get; init; }

    [JsonPropertyName("recent30BusdTotal")]
    public required string Recent30BusdTotal { get; init; }

    [JsonPropertyName("recent30BusdFuturesTotal")]
    public required string Recent30BusdFuturesTotal { get; init; }

    [JsonPropertyName("recent30BusdMarginTotal")]
    public required string Recent30BusdMarginTotal { get; init; }

    [JsonPropertyName("tradeInfoVos")]
    public required IReadOnlyList<TradeInfoVo> TradeInfoVos { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
