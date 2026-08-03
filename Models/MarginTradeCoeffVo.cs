using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

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
}
