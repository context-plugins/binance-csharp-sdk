using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SubAccountList2
{
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    [JsonPropertyName("totalAssetOfBtc")]
    public required string TotalAssetOfBtc { get; init; }

    [JsonPropertyName("totalLiabilityOfBtc")]
    public required string TotalLiabilityOfBtc { get; init; }

    [JsonPropertyName("totalNetAssetOfBtc")]
    public required string TotalNetAssetOfBtc { get; init; }
}
