using System.Text.Json.Serialization;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi.Models;

public record SapiV1DciProductAccountsResponse
{
    /// <summary>
    /// Total BTC amounts in Dual Investment
    /// </summary>
    [JsonPropertyName("totalAmountInBTC")]
    public required string TotalAmountInBtc { get; init; }

    /// <summary>
    /// Total USDT equivalents in BTC in Dual Investment
    /// </summary>
    [JsonPropertyName("totalAmountInUSDT")]
    public required string TotalAmountInUsdt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
