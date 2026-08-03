using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record SapiV1AssetDustBtcResponse
{
    [JsonPropertyName("details")]
    public required IReadOnlyList<Detail> Details { get; init; }

    [JsonPropertyName("totalTransferBtc")]
    public required string TotalTransferBtc { get; init; }

    [JsonPropertyName("totalTransferBNB")]
    public required string TotalTransferBnb { get; init; }

    /// <summary>
    /// Commission fee
    /// </summary>
    [JsonPropertyName("dribbletPercentage")]
    public required string DribbletPercentage { get; init; }
}
