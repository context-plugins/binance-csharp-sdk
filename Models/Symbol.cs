using System.Collections.Generic;
using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Symbol
{
    [JsonPropertyName("symbol")]
    public required string SymbolValue { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("baseAsset")]
    public required string BaseAsset { get; init; }

    [JsonPropertyName("baseAssetPrecision")]
    public required int BaseAssetPrecision { get; init; }

    [JsonPropertyName("quoteAsset")]
    public required string QuoteAsset { get; init; }

    [JsonPropertyName("quoteAssetPrecision")]
    public required int QuoteAssetPrecision { get; init; }

    [JsonPropertyName("baseCommissionPrecision")]
    public required int BaseCommissionPrecision { get; init; }

    [JsonPropertyName("quoteCommissionPrecision")]
    public required int QuoteCommissionPrecision { get; init; }

    [JsonPropertyName("orderTypes")]
    public required IReadOnlyList<string> OrderTypes { get; init; }

    [JsonPropertyName("icebergAllowed")]
    public required bool IcebergAllowed { get; init; }

    [JsonPropertyName("ocoAllowed")]
    public required bool OcoAllowed { get; init; }

    [JsonPropertyName("otoAllowed")]
    public required bool OtoAllowed { get; init; }

    [JsonPropertyName("quoteOrderQtyMarketAllowed")]
    public required bool QuoteOrderQtyMarketAllowed { get; init; }

    [JsonPropertyName("allowTrailingStop")]
    public required bool AllowTrailingStop { get; init; }

    [JsonPropertyName("cancelReplaceAllowed")]
    public required bool CancelReplaceAllowed { get; init; }

    [JsonPropertyName("isSpotTradingAllowed")]
    public required bool IsSpotTradingAllowed { get; init; }

    [JsonPropertyName("isMarginTradingAllowed")]
    public required bool IsMarginTradingAllowed { get; init; }

    [JsonPropertyName("filters")]
    public required IReadOnlyList<Filter> Filters { get; init; }

    [JsonPropertyName("permissions")]
    public required IReadOnlyList<string> Permissions { get; init; }

    [JsonPropertyName("permissionSets")]
    public required IReadOnlyList<IReadOnlyList<string>> PermissionSets { get; init; }

    [JsonPropertyName("defaultSelfTradePreventionMode")]
    public required string DefaultSelfTradePreventionMode { get; init; }

    [JsonPropertyName("allowedSelfTradePreventionModes")]
    public required IReadOnlyList<string> AllowedSelfTradePreventionModes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
