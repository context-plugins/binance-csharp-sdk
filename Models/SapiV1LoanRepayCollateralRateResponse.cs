using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1LoanRepayCollateralRateResponse
{
    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    [JsonPropertyName("repayAmount")]
    public required string RepayAmount { get; init; }

    /// <summary>
    /// rate of collateral coin/loan coin
    /// </summary>
    [JsonPropertyName("rate")]
    public required string Rate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
