using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BinancePublicSpotApi.Models;

public record UserAssetDribblet
{
    [JsonPropertyName("operateTime")]
    public required long OperateTime { get; init; }

    /// <summary>
    /// Total transfered BNB amount for this exchange.
    /// </summary>
    [JsonPropertyName("totalTransferedAmount")]
    public required string TotalTransferedAmount { get; init; }

    /// <summary>
    /// Total service charge amount for this exchange.
    /// </summary>
    [JsonPropertyName("totalServiceChargeAmount")]
    public required string TotalServiceChargeAmount { get; init; }

    [JsonPropertyName("transId")]
    public required long TransId { get; init; }

    [JsonPropertyName("userAssetDribbletDetails")]
    public required IReadOnlyList<UserAssetDribbletDetail> UserAssetDribbletDetails { get; init; }
}
