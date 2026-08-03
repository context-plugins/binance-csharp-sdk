using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SubAccountFuturesPositionRiskResponse
{
    [JsonPropertyName("entryPrice")]
    public required string EntryPrice { get; init; }

    /// <summary>
    /// current initial leverage
    /// </summary>
    [JsonPropertyName("leverage")]
    public required string Leverage { get; init; }

    /// <summary>
    /// notional value limit of current initial leverage
    /// </summary>
    [JsonPropertyName("maxNotional")]
    public required string MaxNotional { get; init; }

    [JsonPropertyName("liquidationPrice")]
    public required string LiquidationPrice { get; init; }

    [JsonPropertyName("markPrice")]
    public required string MarkPrice { get; init; }

    [JsonPropertyName("positionAmount")]
    public required string PositionAmount { get; init; }

    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    [JsonPropertyName("unrealizedProfit")]
    public required string UnrealizedProfit { get; init; }
}
