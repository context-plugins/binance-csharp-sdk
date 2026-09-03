using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Asset
{
    [JsonPropertyName("baseAsset")]
    public required BaseAsset BaseAsset { get; init; }

    [JsonPropertyName("quoteAsset")]
    public required QuoteAsset QuoteAsset { get; init; }

    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("isolatedCreated")]
    public required bool IsolatedCreated { get; init; }

    /// <summary>
    /// true-enabled, false-disabled
    /// </summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; init; }

    [JsonPropertyName("marginLevel")]
    public required string MarginLevel { get; init; }

    /// <summary>
    /// "EXCESSIVE", "NORMAL", "MARGIN_CALL", "PRE_LIQUIDATION", "FORCE_LIQUIDATION"
    /// </summary>
    [JsonPropertyName("marginLevelStatus")]
    public required string MarginLevelStatus { get; init; }

    [JsonPropertyName("marginRatio")]
    public required string MarginRatio { get; init; }

    [JsonPropertyName("indexPrice")]
    public required string IndexPrice { get; init; }

    [JsonPropertyName("liquidatePrice")]
    public required string LiquidatePrice { get; init; }

    [JsonPropertyName("liquidateRate")]
    public required string LiquidateRate { get; init; }

    [JsonPropertyName("tradeEnabled")]
    public required bool TradeEnabled { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
