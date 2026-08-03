using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Row37
{
    [JsonPropertyName("time")]
    public required long Time { get; init; }

    /// <summary>
    /// Estimated rewards accrued within WBETH
    /// </summary>
    [JsonPropertyName("amountInETH")]
    public required string AmountInEth { get; init; }

    /// <summary>
    /// WBETH holding balance
    /// </summary>
    [JsonPropertyName("holding")]
    public required string Holding { get; init; }

    [JsonPropertyName("holdingInETH")]
    public required string HoldingInEth { get; init; }

    [JsonPropertyName("annualPercentageRate")]
    public required string AnnualPercentageRate { get; init; }
}
