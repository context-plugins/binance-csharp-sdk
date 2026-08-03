using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1MarginTradeCoeffResponse
{
    /// <summary>
    /// Account's currently max borrowable amount with sufficient system availability
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("normalBar")]
    public string? NormalBar { get; init; }

    /// <summary>
    /// Max borrowable amount limited by the account level
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("marginCallBar")]
    public string? MarginCallBar { get; init; }

    /// <summary>
    /// Liquidation Margin Ratio
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("forceLiquidationBar")]
    public string? ForceLiquidationBar { get; init; }
}
