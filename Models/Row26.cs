using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record Row26
{
    [JsonPropertyName("loanCoin")]
    public required string LoanCoin { get; init; }

    [JsonPropertyName("initialLoanAmount")]
    public required string InitialLoanAmount { get; init; }

    [JsonPropertyName("collateralCoin")]
    public required string CollateralCoin { get; init; }

    [JsonPropertyName("initialCollateralAmount")]
    public required string InitialCollateralAmount { get; init; }

    [JsonPropertyName("borrowTime")]
    public required long BorrowTime { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }
}
