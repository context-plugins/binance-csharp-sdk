using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record Row28
{
    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    [JsonPropertyName("direction")]
    public required string Direction { get; init; }

    [JsonPropertyName("collateralAmount")]
    public required string CollateralAmount { get; init; }

    [JsonPropertyName("preLTV")]
    public required string PreLtv { get; init; }

    [JsonPropertyName("afterLTV")]
    public required string AfterLtv { get; init; }

    [JsonPropertyName("adjustTime")]
    public required long AdjustTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
