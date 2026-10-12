using System.Text.Json.Serialization;
using Binance.Core.Models;

namespace Binance.Models;

public record MarginTradeCoeffVo
{
    /// <summary>
    /// Liquidation margin ratio
    /// </summary>
    [JsonPropertyName("forceLiquidationBar")]
    public required string ForceLiquidationBar { get; init; }

    /// <summary>
    /// Margin call margin ratio
    /// </summary>
    [JsonPropertyName("marginCallBar")]
    public required string MarginCallBar { get; init; }

    /// <summary>
    /// Initial margin ratio
    /// </summary>
    [JsonPropertyName("normalBar")]
    public required string NormalBar { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
