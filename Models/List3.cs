using System.Collections.Generic;
using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record List3
{
    /// <summary>
    /// 0: purchase order, 1: sell order, 2: royalty income, 3: primary market order, 4: mint fee
    /// </summary>
    [JsonPropertyName("orderNo")]
    public required string OrderNo { get; init; }

    [JsonPropertyName("tokens")]
    public required IReadOnlyList<Token> Tokens { get; init; }

    [JsonPropertyName("tradeTime")]
    public required long TradeTime { get; init; }

    [JsonPropertyName("tradeAmount")]
    public required string TradeAmount { get; init; }

    [JsonPropertyName("tradeCurrency")]
    public required string TradeCurrency { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
