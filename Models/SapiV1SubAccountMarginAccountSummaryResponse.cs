using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SubAccountMarginAccountSummaryResponse
{
    [JsonPropertyName("totalAssetOfBtc")]
    public required string TotalAssetOfBtc { get; init; }

    [JsonPropertyName("totalLiabilityOfBtc")]
    public required string TotalLiabilityOfBtc { get; init; }

    [JsonPropertyName("totalNetAssetOfBtc")]
    public required string TotalNetAssetOfBtc { get; init; }

    [JsonPropertyName("subAccountList")]
    public required IReadOnlyList<SubAccountList2> SubAccountList { get; init; }
}
