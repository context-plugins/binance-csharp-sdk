using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1SubAccountMarginAccountResponse
{
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    [JsonPropertyName("marginLevel")]
    public required string MarginLevel { get; init; }

    [JsonPropertyName("totalAssetOfBtc")]
    public required string TotalAssetOfBtc { get; init; }

    [JsonPropertyName("totalLiabilityOfBtc")]
    public required string TotalLiabilityOfBtc { get; init; }

    [JsonPropertyName("totalNetAssetOfBtc")]
    public required string TotalNetAssetOfBtc { get; init; }

    [JsonPropertyName("marginTradeCoeffVo")]
    public required MarginTradeCoeffVo MarginTradeCoeffVo { get; init; }

    [JsonPropertyName("marginUserAssetVoList")]
    public required IReadOnlyList<MarginUserAssetVoList> MarginUserAssetVoList { get; init; }
}
