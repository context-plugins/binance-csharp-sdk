using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Fill2
{
    [JsonPropertyName("matchType")]
    public required string MatchType { get; init; }

    [JsonPropertyName("price")]
    public required string Price { get; init; }

    [JsonPropertyName("qty")]
    public required string Qty { get; init; }

    [JsonPropertyName("commission")]
    public required string Commission { get; init; }

    [JsonPropertyName("commissionAsset")]
    public required string CommissionAsset { get; init; }

    [JsonPropertyName("tradeId")]
    public required long TradeId { get; init; }

    [JsonPropertyName("allocId")]
    public required long AllocId { get; init; }
}
