using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record Data17
{
    [JsonPropertyName("fifteenMinHashRate")]
    public required string FifteenMinHashRate { get; init; }

    [JsonPropertyName("dayHashRate")]
    public required string DayHashRate { get; init; }

    [JsonPropertyName("validNum")]
    public required long ValidNum { get; init; }

    [JsonPropertyName("invalidNum")]
    public required long InvalidNum { get; init; }

    [JsonPropertyName("profitToday")]
    public required ProfitToday ProfitToday { get; init; }

    [JsonPropertyName("profitYesterday")]
    public required ProfitYesterday ProfitYesterday { get; init; }

    [JsonPropertyName("userName")]
    public required string UserName { get; init; }

    [JsonPropertyName("unit")]
    public required string Unit { get; init; }

    [JsonPropertyName("algo")]
    public required string Algo { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
